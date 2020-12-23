/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.LocationService;
using Amazon.LocationService.Model;

namespace Amazon.PowerShell.Cmdlets.LOC
{
    /// <summary>
    /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
    /// for Places or points of interest near a given position.
    /// 
    ///  <note><para>
    /// By using Places, you agree that AWS may transmit your API queries to your selected
    /// third party provider for processing, which may be outside the AWS region you are currently
    /// using. 
    /// </para><para>
    /// Because of licensing limitations, you may not use HERE to store results for locations
    /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
    /// Service Terms</a> for Amazon Location Service.
    /// </para></note>
    /// </summary>
    [Cmdlet("Search", "LOCPlaceIndexForPosition")]
    [OutputType("Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse")]
    [AWSCmdlet("Calls the Amazon Location Service SearchPlaceIndexForPosition API operation.", Operation = new[] {"SearchPlaceIndexForPosition"}, SelectReturnType = typeof(Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse))]
    [AWSCmdletOutput("Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse",
        "This cmdlet returns an Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class SearchLOCPlaceIndexForPositionCmdlet : AmazonLocationServiceClientCmdlet, IExecutor
    {
        
        #region Parameter IndexName
        /// <summary>
        /// <para>
        /// <para>The name of the Place index resource you want to use for the search.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String IndexName { get; set; }
        #endregion
        
        #region Parameter Position
        /// <summary>
        /// <para>
        /// <para>Specifies a coordinate for the query defined by a longitude, and latitude.</para><ul><li><para>The first position is the X coordinate, or longitude.</para></li><li><para>The second position is the Y coordinate, or latitude. </para></li></ul><para>For example, <code>position=xLongitude&amp;position=yLatitude</code> .</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Double[] Position { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>An optional paramer. The maximum number of results returned per request. </para><para>Default value: <code>50</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse).
        /// Specifying the name of a property of type Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the IndexName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^IndexName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^IndexName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse, SearchLOCPlaceIndexForPositionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.IndexName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.IndexName = this.IndexName;
            #if MODULAR
            if (this.IndexName == null && ParameterWasBound(nameof(this.IndexName)))
            {
                WriteWarning("You are passing $null as a value for parameter IndexName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MaxResult = this.MaxResult;
            if (this.Position != null)
            {
                context.Position = new List<System.Double>(this.Position);
            }
            #if MODULAR
            if (this.Position == null && ParameterWasBound(nameof(this.Position)))
            {
                WriteWarning("You are passing $null as a value for parameter Position which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.LocationService.Model.SearchPlaceIndexForPositionRequest();
            
            if (cmdletContext.IndexName != null)
            {
                request.IndexName = cmdletContext.IndexName;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.Position != null)
            {
                request.Position = cmdletContext.Position;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse CallAWSServiceOperation(IAmazonLocationService client, Amazon.LocationService.Model.SearchPlaceIndexForPositionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Location Service", "SearchPlaceIndexForPosition");
            try
            {
                #if DESKTOP
                return client.SearchPlaceIndexForPosition(request);
                #elif CORECLR
                return client.SearchPlaceIndexForPositionAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String IndexName { get; set; }
            public System.Int32? MaxResult { get; set; }
            public List<System.Double> Position { get; set; }
            public System.Func<Amazon.LocationService.Model.SearchPlaceIndexForPositionResponse, SearchLOCPlaceIndexForPositionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}