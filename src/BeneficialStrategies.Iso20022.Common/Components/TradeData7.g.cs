﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeData7.  ISO2002 ID# _0HqjAew3EeGdCpA_VUPR-w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
public partial record TradeData7
     : IIsoXmlSerilizable<TradeData7>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    public IsoMax35Text? OriginatorReference { get; init; } 
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; } 
    /// <summary>
    /// Unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; } 
    /// <summary>
    /// Identification to the unique reference from the central settlement system that allows the removal of alleged trades once the matched status notification for the matching side has been received.
    /// </summary>
    public IsoMax35Text? MatchingSystemMatchedSideReference { get; init; } 
    /// <summary>
    /// Party that assigned the status to the foreign exchange or derivative trade.
    /// </summary>
    public IsoMax20Text? StatusOriginator { get; init; } 
    /// <summary>
    /// Specifies the new status of a trade.
    /// </summary>
    public required StatusAndSubStatus1 CurrentStatus { get; init; } 
    /// <summary>
    /// Additional information on the current status of a trade in a central system.
    /// </summary>
    public StatusSubType1Code? CurrentStatusSubType { get; init; } 
    /// <summary>
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    public IsoISODateTime? CurrentStatusDateTime { get; init; } 
    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    public Status6Choice_? PreviousStatus { get; init; } 
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    public StatusSubType1Code? PreviousStatusSubType { get; init; } 
    /// <summary>
    /// Specifies the date and time at which the previous status was assigned.
    /// </summary>
    public IsoISODateTime? PreviousStatusDateTime { get; init; } 
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    public IsoMax35Text? ProductType { get; init; } 
    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    /// <summary>
    /// To indicate if the trade is split.
    /// </summary>
    public IsoYesNoIndicator? SplitTradeIndicator { get; init; } 
    
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
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginatorReference is IsoMax35Text OriginatorReferenceValue)
        {
            writer.WriteStartElement(null, "OrgtrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginatorReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MtchgSysUnqRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MatchingSystemUniqueReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (MatchingSystemMatchingReference is IsoMax35Text MatchingSystemMatchingReferenceValue)
        {
            writer.WriteStartElement(null, "MtchgSysMtchgRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MatchingSystemMatchingReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MatchingSystemMatchedSideReference is IsoMax35Text MatchingSystemMatchedSideReferenceValue)
        {
            writer.WriteStartElement(null, "MtchgSysMtchdSdRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MatchingSystemMatchedSideReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (StatusOriginator is IsoMax20Text StatusOriginatorValue)
        {
            writer.WriteStartElement(null, "StsOrgtr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax20Text(StatusOriginatorValue)); // data type Max20Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CurSts", xmlNamespace );
        CurrentStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CurrentStatusSubType is StatusSubType1Code CurrentStatusSubTypeValue)
        {
            writer.WriteStartElement(null, "CurStsSubTp", xmlNamespace );
            writer.WriteValue(CurrentStatusSubTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CurrentStatusDateTime is IsoISODateTime CurrentStatusDateTimeValue)
        {
            writer.WriteStartElement(null, "CurStsDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(CurrentStatusDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (PreviousStatus is Status6Choice_ PreviousStatusValue)
        {
            writer.WriteStartElement(null, "PrvsSts", xmlNamespace );
            PreviousStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousStatusSubType is StatusSubType1Code PreviousStatusSubTypeValue)
        {
            writer.WriteStartElement(null, "PrvsStsSubTp", xmlNamespace );
            writer.WriteValue(PreviousStatusSubTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PreviousStatusDateTime is IsoISODateTime PreviousStatusDateTimeValue)
        {
            writer.WriteStartElement(null, "PrvsStsDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(PreviousStatusDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ProductType is IsoMax35Text ProductTypeValue)
        {
            writer.WriteStartElement(null, "PdctTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProductTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SettlementSessionIdentifier is IsoExact4AlphaNumericText SettlementSessionIdentifierValue)
        {
            writer.WriteStartElement(null, "SttlmSsnIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact4AlphaNumericText(SettlementSessionIdentifierValue)); // data type Exact4AlphaNumericText System.String
            writer.WriteEndElement();
        }
        if (SplitTradeIndicator is IsoYesNoIndicator SplitTradeIndicatorValue)
        {
            writer.WriteStartElement(null, "SpltTradInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SplitTradeIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static TradeData7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
