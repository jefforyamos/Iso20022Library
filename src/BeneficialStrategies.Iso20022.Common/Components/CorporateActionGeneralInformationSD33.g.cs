﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD33.  ISO2002 ID# _g9dp8eaNEei5aPS232E3Mw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information details.
/// </summary>
public partial record CorporateActionGeneralInformationSD33
     : IIsoXmlSerilizable<CorporateActionGeneralInformationSD33>
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    public EventGroup1Code? EventGroup { get; init; } 
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    public ExtendedEventType6Code? EventType { get; init; } 
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    public DTCCSubEventType7Code? SubEventType { get; init; } 
    /// <summary>
    /// Indicates whether the event is eligible for Elective Dividend Services instruction messaging or voluntary reorganization instruction messaging.
    /// </summary>
    public IsoYesNoIndicator? InstructionMessagingEligibilityFlag { get; init; } 
    /// <summary>
    /// Unique number systemically assigned to all lottery and non-lottery events announced in DTC redemptions (REDS) participant terminal system (PTS)/ participant browser system(PBS) function.
    /// </summary>
    public IsoMax10NumericText? RedemptionIdentification { get; init; } 
    /// <summary>
    /// Identifies events that offer instruction processing specific to foreign currency payment (FCP) elections.
    /// </summary>
    public IsoYesNoIndicator? DTCFCPElectionFlag { get; init; } 
    /// <summary>
    /// Indicates whether the event is being processed by DTC.
    /// </summary>
    public IsoYesNoIndicator? AssetServicerProcessingFlag { get; init; } 
    
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
        if (PlaceAndName is IsoMax350Text PlaceAndNameValue)
        {
            writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (EventGroup is EventGroup1Code EventGroupValue)
        {
            writer.WriteStartElement(null, "EvtGrp", xmlNamespace );
            writer.WriteValue(EventGroupValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (EventType is ExtendedEventType6Code EventTypeValue)
        {
            writer.WriteStartElement(null, "EvtTp", xmlNamespace );
            writer.WriteValue(EventTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SubEventType is DTCCSubEventType7Code SubEventTypeValue)
        {
            writer.WriteStartElement(null, "SubEvtTp", xmlNamespace );
            writer.WriteValue(SubEventTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (InstructionMessagingEligibilityFlag is IsoYesNoIndicator InstructionMessagingEligibilityFlagValue)
        {
            writer.WriteStartElement(null, "InstrMsggElgbltyFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(InstructionMessagingEligibilityFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (RedemptionIdentification is IsoMax10NumericText RedemptionIdentificationValue)
        {
            writer.WriteStartElement(null, "RedId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10NumericText(RedemptionIdentificationValue)); // data type Max10NumericText System.String
            writer.WriteEndElement();
        }
        if (DTCFCPElectionFlag is IsoYesNoIndicator DTCFCPElectionFlagValue)
        {
            writer.WriteStartElement(null, "DTCFCPElctnFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(DTCFCPElectionFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (AssetServicerProcessingFlag is IsoYesNoIndicator AssetServicerProcessingFlagValue)
        {
            writer.WriteStartElement(null, "AsstSvcrPrcgFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(AssetServicerProcessingFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionGeneralInformationSD33 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
