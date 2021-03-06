// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Insights.Legacy.Models
{
    /// <summary>
    /// Contains the information for blobs. Each one is used for a specific
    /// time range.
    /// </summary>
    public partial class BlobInfo
    {
        private string _blobUri;
        
        /// <summary>
        /// Optional. Gets or sets the blob info.
        /// </summary>
        public string BlobUri
        {
            get { return this._blobUri; }
            set { this._blobUri = value; }
        }
        
        private DateTime _endTime;
        
        /// <summary>
        /// Optional. Gets or sets the end time of the range for this blob.
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _sasToken;
        
        /// <summary>
        /// Optional. Gets or sets the SAS Key for accessing Blob Storage.
        /// </summary>
        public string SasToken
        {
            get { return this._sasToken; }
            set { this._sasToken = value; }
        }
        
        private DateTime _sasTokenExpirationTime;
        
        /// <summary>
        /// Optional. Gets or sets the expiration time of the SAS token (UTC).
        /// </summary>
        public DateTime SasTokenExpirationTime
        {
            get { return this._sasTokenExpirationTime; }
            set { this._sasTokenExpirationTime = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time of the range for this blob.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BlobInfo class.
        /// </summary>
        public BlobInfo()
        {
        }
    }
}
