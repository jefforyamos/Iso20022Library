﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Terminal3.  ISO2002 ID# _e4IxaewNEeiMkKo2clXHdQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terminal or ATM performing the transaction
/// </summary>
public partial record Terminal3
     : IIsoXmlSerilizable<Terminal3>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    public TerminalIdentification2? TerminalIdentification { get; init; } 
    /// <summary>
    /// Capabilities of the terminal.
    /// </summary>
    public Capabilities1? Capabilities { get; init; } 
    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-2
    /// </summary>
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; } 
    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; init; } 
    /// <summary>
    /// Indicates whether the terminal is operated outdoor or indoor at the point of service.
    /// True: The terminal is operated outdoor.
    /// False: The terminal is operated indoor.
    /// </summary>
    public IsoTrueFalseIndicator? OutdoorIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the terminal is operated on- or off-premises at the point of service.
    /// True: The terminal is operated off premises.
    /// False: The terminal is operated on premises.
    /// ISO 8583:93 bit 22-4, ISO 8583:2003 bit 22-3.
    /// </summary>
    public IsoTrueFalseIndicator? OffPremisesIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the transaction was performed on board.
    /// True: The terminal is located on board.
    /// False: The terminal is not located on board.
    /// </summary>
    public IsoTrueFalseIndicator? OnBoardIndicator { get; init; } 
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the transactions.
    /// </summary>
    public PointOfInteractionComponent8? POIComponent { get; init; } 
    
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
        if (TerminalIdentification is TerminalIdentification2 TerminalIdentificationValue)
        {
            writer.WriteStartElement(null, "TermnlId", xmlNamespace );
            TerminalIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Capabilities is Capabilities1 CapabilitiesValue)
        {
            writer.WriteStartElement(null, "Cpblties", xmlNamespace );
            CapabilitiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardholderVerificationCapability is CardholderVerificationCapabilities1 CardholderVerificationCapabilityValue)
        {
            writer.WriteStartElement(null, "CrdhldrVrfctnCpblty", xmlNamespace );
            CardholderVerificationCapabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminalIntegration is TerminalIntegrationCategory1Code TerminalIntegrationValue)
        {
            writer.WriteStartElement(null, "TermnlIntgtn", xmlNamespace );
            writer.WriteValue(TerminalIntegrationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OutdoorIndicator is IsoTrueFalseIndicator OutdoorIndicatorValue)
        {
            writer.WriteStartElement(null, "OutdrInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(OutdoorIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (OffPremisesIndicator is IsoTrueFalseIndicator OffPremisesIndicatorValue)
        {
            writer.WriteStartElement(null, "OffPrmissInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(OffPremisesIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (OnBoardIndicator is IsoTrueFalseIndicator OnBoardIndicatorValue)
        {
            writer.WriteStartElement(null, "OnBrdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(OnBoardIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (POIComponent is PointOfInteractionComponent8 POIComponentValue)
        {
            writer.WriteStartElement(null, "POICmpnt", xmlNamespace );
            POIComponentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Terminal3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
