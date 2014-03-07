/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type containing the response information for the new hosted zone.</para>
    /// </summary>
    public partial class CreateHostedZoneResult : AmazonWebServiceResponse
    {
        
        private HostedZone hostedZone;
        private ChangeInfo changeInfo;
        private DelegationSet delegationSet;
        private string location;


        /// <summary>
        /// A complex type that contains identifying information about the hosted zone.
        ///  
        /// </summary>
        public HostedZone HostedZone
        {
            get { return this.hostedZone; }
            set { this.hostedZone = value; }
        }

        // Check to see if HostedZone property is set
        internal bool IsSetHostedZone()
        {
            return this.hostedZone != null;
        }

        /// <summary>
        /// A complex type that contains information about the request to create a hosted zone. This includes an ID that you use when you call the
        /// <a>GetChange</a> action to get the current status of the change request.
        ///  
        /// </summary>
        public ChangeInfo ChangeInfo
        {
            get { return this.changeInfo; }
            set { this.changeInfo = value; }
        }

        // Check to see if ChangeInfo property is set
        internal bool IsSetChangeInfo()
        {
            return this.changeInfo != null;
        }

        /// <summary>
        /// A complex type that contains name server information.
        ///  
        /// </summary>
        public DelegationSet DelegationSet
        {
            get { return this.delegationSet; }
            set { this.delegationSet = value; }
        }

        // Check to see if DelegationSet property is set
        internal bool IsSetDelegationSet()
        {
            return this.delegationSet != null;
        }

        /// <summary>
        /// The unique URL representing the new hosted zone.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }
    }
}
