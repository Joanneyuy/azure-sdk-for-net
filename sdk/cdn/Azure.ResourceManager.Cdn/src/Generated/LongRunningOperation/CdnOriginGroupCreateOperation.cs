// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Creates a new origin group within the specified endpoint. </summary>
    public partial class CdnOriginGroupCreateOperation : Operation<CdnOriginGroup>, IOperationSource<CdnOriginGroup>
    {
        private readonly OperationInternals<CdnOriginGroup> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of CdnOriginGroupCreateOperation for mocking. </summary>
        protected CdnOriginGroupCreateOperation()
        {
        }

        internal CdnOriginGroupCreateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CdnOriginGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CdnOriginGroupCreateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CdnOriginGroup Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CdnOriginGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CdnOriginGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CdnOriginGroup IOperationSource<CdnOriginGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new CdnOriginGroup(_operationBase, CdnOriginGroupData.DeserializeCdnOriginGroupData(document.RootElement));
        }

        async ValueTask<CdnOriginGroup> IOperationSource<CdnOriginGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new CdnOriginGroup(_operationBase, CdnOriginGroupData.DeserializeCdnOriginGroupData(document.RootElement));
        }
    }
}
