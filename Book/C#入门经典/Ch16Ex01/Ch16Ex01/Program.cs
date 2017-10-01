using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using System.IO;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Ch16Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                #region Create Conatiner for card deck
                /* Create the container, the storage account must already exist  */
                // Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = 
                    CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
                // Create the blob client.
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                // Retrieve a reference to a container.
                CloudBlobContainer container = blobClient.GetContainerReference("carddeck");
                // Create the container if it doesn't already exist.
                if (container.CreateIfNotExists())
                {
                    WriteLine($"Created container '{container.Name}' " + 
                        $"in storage account '{storageAccount.Credentials.AccountName}'.");
                }
                else
                {
                    WriteLine($"Container '{container.Name}' already exists " +
                        $"for storage account '{storageAccount.Credentials.AccountName}'.");
                }
                //Containers are private by default, set to public and accessible to everyone
                container.SetPermissions(new BlobContainerPermissions
                        { PublicAccess = BlobContainerPublicAccessType.Blob });
                WriteLine($"Permission for container '{container.Name}' is public.");
                #endregion
                #region Upload deck of cards
                /* Upload card images as blobs to the container  */
                int numberOfCards = 0;
                DirectoryInfo dir = new DirectoryInfo(@"Cards");
                foreach (FileInfo f in dir.GetFiles("*.*"))
                {
                    // Retrieve reference to a blob named "*.PNG"
                    CloudBlockBlob blockBlob = container.GetBlockBlobReference(f.Name);
                    // Create or overwrite the "*.PNG" blob with contents from the local file.
                    using (var fileStream = System.IO.File.OpenRead(@"Cards\" + f.Name))
                    {
                        blockBlob.UploadFromStream(fileStream);
                        WriteLine($"Uploading: '{f.Name}' which " +
                            $"is {fileStream.Length} bytes.");
                    }
                    numberOfCards++;
                }
                WriteLine($"Uploaded {numberOfCards.ToString()} cards.");
                WriteLine();
                #endregion
                #region List blobs in container
                /* List the blob card images in a container */
                // Loop over items within the container and output the length and URI.
                numberOfCards = 0;
                foreach (IListBlobItem item in container.ListBlobs(null, false))
                {
                    if (item.GetType() == typeof(CloudBlockBlob))
                    {
                        CloudBlockBlob blob = (CloudBlockBlob)item;
                        WriteLine($"Card image url '{blob.Uri}' with length of {blob.Properties.Length}");
                    }
                    numberOfCards++;
                }
                WriteLine($"Listed {numberOfCards.ToString()} cards.");
                #endregion
                #region Delete Blobs
                // Retrieve reference to a blob and delete it
                WriteLine("Enter Y to delete listed cards, press enter to skip deletion:");
                if (ReadLine() == "Y")
                {
                    numberOfCards = 0;
                    foreach (IListBlobItem item in container.ListBlobs(null, false))
                    {
                        CloudBlockBlob blob = (CloudBlockBlob)item;
                        CloudBlockBlob blockBlobToDelete = container.GetBlockBlobReference(blob.Name);
                        blockBlobToDelete.Delete();
                        WriteLine($"Deleted: '{blob.Name}' which was {blob.Name.Length} bytes.");
                        numberOfCards++;
                    }
                    WriteLine($"Deleted {numberOfCards.ToString()} cards.");
                }
                #endregion
            }
            catch (StorageException ex)
            {
                WriteLine($"StorageException: {ex.Message}");
            }
            catch (Exception ex)
            {
                WriteLine($"Exception: {ex.Message}");
            }

            WriteLine("Press enter to exit.");
            ReadLine();
        }

    }
}
