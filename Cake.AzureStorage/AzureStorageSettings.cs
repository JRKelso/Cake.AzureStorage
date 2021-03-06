﻿namespace Cake.AzureStorage {
    /// <summary>
    ///     Initializes a new instance of the <see cref="AzureStorageSettings"/> class.
    /// </summary>
    public class AzureStorageSettings {
        /// <summary>
        /// Gets or sets the Azure account name.
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// Gets or sets the Azure API Key.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Gets or sets the Azure container name.
        /// </summary>
        public string ContainerName { get; set; }
        /// <summary>
        /// Gets or sets the Azure blob name.
        /// </summary>
        public string BlobName { get; set; }
        /// <summary>
        /// Gets or sets wethere to use HTTPS or not, 
        /// </summary>
        /// <value>
        ///     <c>true</c> to use HTTPS, default; otherwise, <c>false</c>.
        /// </value>
        public bool UseHttps { get; set; }

        public AzureStorageSettings() {
            UseHttps = true;
        }
    }
}
