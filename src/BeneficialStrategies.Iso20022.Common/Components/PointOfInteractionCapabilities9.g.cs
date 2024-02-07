﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionCapabilities9.  ISO2002 ID# _n5BG4Q0yEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the POI (Point Of Interaction) performing the transaction.
/// </summary>
public partial record PointOfInteractionCapabilities9
     : IIsoXmlSerilizable<PointOfInteractionCapabilities9>
{
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public CardDataReading8Code? CardReadingCapabilities { get; init; } 
    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; init; } 
    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    public IsoPositiveNumber? PINLengthCapabilities { get; init; } 
    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    public IsoPositiveNumber? ApprovalCodeLength { get; init; } 
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    public IsoPositiveNumber? MaxScriptLength { get; init; } 
    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    public DisplayCapabilities4? MessageCapabilities { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CardReadingCapabilities is CardDataReading8Code CardReadingCapabilitiesValue)
        {
            writer.WriteStartElement(null, "CardRdngCpblties", xmlNamespace );
            writer.WriteValue(CardReadingCapabilitiesValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CardholderVerificationCapabilities is CardholderVerificationCapability4Code CardholderVerificationCapabilitiesValue)
        {
            writer.WriteStartElement(null, "CrdhldrVrfctnCpblties", xmlNamespace );
            writer.WriteValue(CardholderVerificationCapabilitiesValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PINLengthCapabilities is IsoPositiveNumber PINLengthCapabilitiesValue)
        {
            writer.WriteStartElement(null, "PINLngthCpblties", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPositiveNumber(PINLengthCapabilitiesValue)); // data type PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (ApprovalCodeLength is IsoPositiveNumber ApprovalCodeLengthValue)
        {
            writer.WriteStartElement(null, "ApprvlCdLngth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPositiveNumber(ApprovalCodeLengthValue)); // data type PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (MaxScriptLength is IsoPositiveNumber MaxScriptLengthValue)
        {
            writer.WriteStartElement(null, "MxScrptLngth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPositiveNumber(MaxScriptLengthValue)); // data type PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (CardCaptureCapable is IsoTrueFalseIndicator CardCaptureCapableValue)
        {
            writer.WriteStartElement(null, "CardCaptrCpbl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CardCaptureCapableValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (OnLineCapabilities is OnLineCapability1Code OnLineCapabilitiesValue)
        {
            writer.WriteStartElement(null, "OnLineCpblties", xmlNamespace );
            writer.WriteValue(OnLineCapabilitiesValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (MessageCapabilities is DisplayCapabilities4 MessageCapabilitiesValue)
        {
            writer.WriteStartElement(null, "MsgCpblties", xmlNamespace );
            MessageCapabilitiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PointOfInteractionCapabilities9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
