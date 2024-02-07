﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Capabilities2.  ISO2002 ID# _e3RowaH4EeuiuNcvKhXmNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the terminal.
/// </summary>
public partial record Capabilities2
     : IIsoXmlSerilizable<Capabilities2>
{
    #nullable enable
    
    /// <summary>
    /// Card reading capability of the terminal performing the transaction.
    /// </summary>
    public CardReadingCapabilities1? CardReadingCapability { get; init; } 
    /// <summary>
    /// Card writing or output capabilities of the terminal performing the transaction.
    /// </summary>
    public CardWritingCapabilities1? CardWritingCapability { get; init; } 
    /// <summary>
    /// Maximum number of digits that the Point of Interaction is able to accept when the cardholder enters its PIN.
    /// </summary>
    public IsoNumber? PINLengthCapability { get; init; } 
    /// <summary>
    /// Security characteristic of the PIN Entry device solution.
    /// </summary>
    public PINEntrySecurityCharacteristic1Code? PINEntrySecurityCharacteristic { get; init; } 
    /// <summary>
    /// Other privately or nationally assigned code.
    /// </summary>
    public IsoMax35Text? OtherPINEntrySecurityCharacteristic { get; init; } 
    /// <summary>
    /// Maximum number of characters of the approval code that the acquirer is able to manage.
    /// </summary>
    public IsoNumber? ApprovalCodeLength { get; init; } 
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    public IsoNumber? MaxScriptLength { get; init; } 
    /// <summary>
    /// Indicates whether the terminal can capture cards or not.
    /// True: The terminal is able to capture cards
    /// False: The terminal is not able to capture cards.
    /// </summary>
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    /// <summary>
    /// Capability of the terminal to go online.
    /// </summary>
    public OnLineCapability2Code? OnLineCapability { get; init; } 
    /// <summary>
    /// Capability of the terminal to display or print messages to the cardholder or the merchant.
    /// </summary>
    public DisplayCapabilities6? MessageCapability { get; init; } 
    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// </summary>
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; } 
    /// <summary>
    /// Terminal is capable of temporary secure storage of the card details for reuse upon permission of the card issuer.
    /// Default meaning when not present: false.
    /// </summary>
    public IsoTrueFalseIndicator? TemporarySecureCardDataStorage { get; init; } 
    
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
        if (CardReadingCapability is CardReadingCapabilities1 CardReadingCapabilityValue)
        {
            writer.WriteStartElement(null, "CardRdngCpblty", xmlNamespace );
            CardReadingCapabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardWritingCapability is CardWritingCapabilities1 CardWritingCapabilityValue)
        {
            writer.WriteStartElement(null, "CardWrtgCpblty", xmlNamespace );
            CardWritingCapabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PINLengthCapability is IsoNumber PINLengthCapabilityValue)
        {
            writer.WriteStartElement(null, "PINLngthCpblty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(PINLengthCapabilityValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (PINEntrySecurityCharacteristic is PINEntrySecurityCharacteristic1Code PINEntrySecurityCharacteristicValue)
        {
            writer.WriteStartElement(null, "PINNtrySctyChrtc", xmlNamespace );
            writer.WriteValue(PINEntrySecurityCharacteristicValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherPINEntrySecurityCharacteristic is IsoMax35Text OtherPINEntrySecurityCharacteristicValue)
        {
            writer.WriteStartElement(null, "OthrPINNtrySctyChrtc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherPINEntrySecurityCharacteristicValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ApprovalCodeLength is IsoNumber ApprovalCodeLengthValue)
        {
            writer.WriteStartElement(null, "ApprvlCdLngth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(ApprovalCodeLengthValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (MaxScriptLength is IsoNumber MaxScriptLengthValue)
        {
            writer.WriteStartElement(null, "MxScrptLngth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(MaxScriptLengthValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (CardCaptureCapable is IsoTrueFalseIndicator CardCaptureCapableValue)
        {
            writer.WriteStartElement(null, "CardCaptrCpbl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CardCaptureCapableValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (OnLineCapability is OnLineCapability2Code OnLineCapabilityValue)
        {
            writer.WriteStartElement(null, "OnLineCpblty", xmlNamespace );
            writer.WriteValue(OnLineCapabilityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (MessageCapability is DisplayCapabilities6 MessageCapabilityValue)
        {
            writer.WriteStartElement(null, "MsgCpblty", xmlNamespace );
            MessageCapabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardholderVerificationCapability is CardholderVerificationCapabilities1 CardholderVerificationCapabilityValue)
        {
            writer.WriteStartElement(null, "CrdhldrVrfctnCpblty", xmlNamespace );
            CardholderVerificationCapabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TemporarySecureCardDataStorage is IsoTrueFalseIndicator TemporarySecureCardDataStorageValue)
        {
            writer.WriteStartElement(null, "TempScrCardDataStorg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(TemporarySecureCardDataStorageValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static Capabilities2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
