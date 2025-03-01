// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMware;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    /// <summary> Create Or Update InventoryItem. </summary>
    public partial class InventoryItemCreateOperation : Operation<InventoryItem>
    {
        private readonly OperationOrResponseInternals<InventoryItem> _operation;

        /// <summary> Initializes a new instance of InventoryItemCreateOperation for mocking. </summary>
        protected InventoryItemCreateOperation()
        {
        }

        internal InventoryItemCreateOperation(ArmResource operationsBase, Response<InventoryItemData> response)
        {
            _operation = new OperationOrResponseInternals<InventoryItem>(Response.FromValue(new InventoryItem(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override InventoryItem Value => _operation.Value;

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
        public override ValueTask<Response<InventoryItem>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<InventoryItem>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
