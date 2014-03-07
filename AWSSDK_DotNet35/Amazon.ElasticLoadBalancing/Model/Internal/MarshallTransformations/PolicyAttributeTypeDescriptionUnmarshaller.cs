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
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   PolicyAttributeTypeDescription Unmarshaller
     /// </summary>
    internal class PolicyAttributeTypeDescriptionUnmarshaller : IUnmarshaller<PolicyAttributeTypeDescription, XmlUnmarshallerContext>, IUnmarshaller<PolicyAttributeTypeDescription, JsonUnmarshallerContext> 
    {
        public PolicyAttributeTypeDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            PolicyAttributeTypeDescription policyAttributeTypeDescription = new PolicyAttributeTypeDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AttributeName", targetDepth))
                    {
                        policyAttributeTypeDescription.AttributeName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AttributeType", targetDepth))
                    {
                        policyAttributeTypeDescription.AttributeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        policyAttributeTypeDescription.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        policyAttributeTypeDescription.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Cardinality", targetDepth))
                    {
                        policyAttributeTypeDescription.Cardinality = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return policyAttributeTypeDescription;
                }
            }
                        


            return policyAttributeTypeDescription;
        }

        public PolicyAttributeTypeDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static PolicyAttributeTypeDescriptionUnmarshaller instance;

        public static PolicyAttributeTypeDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PolicyAttributeTypeDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
