﻿namespace LiGet.Configuration
{
    public class LiGetOptions
    {
        /// <summary>
        /// The SHA-256 hash of the API Key required to authenticate package
        /// operations. If empty, package operations do not require authentication.
        /// </summary>
        public string ApiKeyHash { get; set; }

        /// <summary>
        /// How LiGet should interpret package deletion requests.
        /// </summary>
        public PackageDeletionBehavior PackageDeletionBehavior { get; set; } = PackageDeletionBehavior.Unlist;

        public DatabaseOptions Database { get; set; }
        public StorageOptions Storage { get; set; }
        public SearchOptions Search { get; set; }

        public CacheOptions Cache { get; set; }

        public BaGetCompatibilityOptions BaGetCompat { get; set; }
    }
}
