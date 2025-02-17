// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EdgeOrder
{
    public partial class OrderItemResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("orderItemDetails");
            writer.WriteObjectValue(OrderItemDetails);
            writer.WritePropertyName("addressDetails");
            writer.WriteObjectValue(AddressDetails);
            writer.WritePropertyName("orderId");
            writer.WriteStringValue(OrderId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static OrderItemResourceData DeserializeOrderItemResourceData(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            IDictionary<string, string> tags = default;
            Location location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            OrderItemDetails orderItemDetails = default;
            AddressDetails addressDetails = default;
            Optional<DateTimeOffset> startTime = default;
            string orderId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("orderItemDetails"))
                        {
                            orderItemDetails = OrderItemDetails.DeserializeOrderItemDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("addressDetails"))
                        {
                            addressDetails = AddressDetails.DeserializeAddressDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("orderId"))
                        {
                            orderId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new OrderItemResourceData(id, name, type, tags, location, systemData, orderItemDetails, addressDetails, Optional.ToNullable(startTime), orderId);
        }
    }
}
