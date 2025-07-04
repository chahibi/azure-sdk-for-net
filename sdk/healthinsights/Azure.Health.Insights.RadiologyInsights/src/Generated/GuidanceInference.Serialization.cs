// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class GuidanceInference : IUtf8JsonSerializable, IJsonModel<GuidanceInference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuidanceInference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GuidanceInference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidanceInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuidanceInference)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("finding"u8);
            writer.WriteObjectValue(Finding, options);
            writer.WritePropertyName("identifier"u8);
            writer.WriteObjectValue(Identifier, options);
            if (Optional.IsCollectionDefined(PresentGuidanceInformation))
            {
                writer.WritePropertyName("presentGuidanceInformation"u8);
                writer.WriteStartArray();
                foreach (var item in PresentGuidanceInformation)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("ranking"u8);
            writer.WriteStringValue(Ranking.ToString());
            if (Optional.IsCollectionDefined(RecommendationProposals))
            {
                writer.WritePropertyName("recommendationProposals"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendationProposals)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MissingGuidanceInformation))
            {
                writer.WritePropertyName("missingGuidanceInformation"u8);
                writer.WriteStartArray();
                foreach (var item in MissingGuidanceInformation)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
        }

        GuidanceInference IJsonModel<GuidanceInference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidanceInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuidanceInference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuidanceInference(document.RootElement, options);
        }

        internal static GuidanceInference DeserializeGuidanceInference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FindingInference finding = default;
            FhirR4CodeableConcept identifier = default;
            IReadOnlyList<PresentGuidanceInformation> presentGuidanceInformation = default;
            GuidanceRankingType ranking = default;
            IReadOnlyList<FollowupRecommendationInference> recommendationProposals = default;
            IReadOnlyList<string> missingGuidanceInformation = default;
            RadiologyInsightsInferenceType kind = default;
            IReadOnlyList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("finding"u8))
                {
                    finding = FindingInference.DeserializeFindingInference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    identifier = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("presentGuidanceInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PresentGuidanceInformation> array = new List<PresentGuidanceInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RadiologyInsights.PresentGuidanceInformation.DeserializePresentGuidanceInformation(item, options));
                    }
                    presentGuidanceInformation = array;
                    continue;
                }
                if (property.NameEquals("ranking"u8))
                {
                    ranking = new GuidanceRankingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recommendationProposals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FollowupRecommendationInference> array = new List<FollowupRecommendationInference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FollowupRecommendationInference.DeserializeFollowupRecommendationInference(item, options));
                    }
                    recommendationProposals = array;
                    continue;
                }
                if (property.NameEquals("missingGuidanceInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    missingGuidanceInformation = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new RadiologyInsightsInferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extension.DeserializeFhirR4Extension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GuidanceInference(
                kind,
                extension ?? new ChangeTrackingList<FhirR4Extension>(),
                serializedAdditionalRawData,
                finding,
                identifier,
                presentGuidanceInformation ?? new ChangeTrackingList<PresentGuidanceInformation>(),
                ranking,
                recommendationProposals ?? new ChangeTrackingList<FollowupRecommendationInference>(),
                missingGuidanceInformation ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<GuidanceInference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidanceInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureHealthInsightsRadiologyInsightsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(GuidanceInference)} does not support writing '{options.Format}' format.");
            }
        }

        GuidanceInference IPersistableModel<GuidanceInference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuidanceInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGuidanceInference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuidanceInference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuidanceInference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new GuidanceInference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGuidanceInference(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
