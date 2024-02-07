﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Correction.  ISO2002 ID# _o0KFZ1osEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport31Choice;

/// <summary>
/// Indicates that the report is correcting the erroneous data fields of a previously submitted position.
/// </summary>
public partial record Correction : TradeReport31Choice_
     , IIsoXmlSerilizable<Correction>
{
    #nullable enable
    
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    public IsoISODateTime? ReportingTimeStamp { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required TradeCounterpartyReport20 CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public IsoISODate? EventDate { get; init; } 
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty. 
    /// </summary>
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// </summary>
    public required MarginCollateralReport4 Collateral { get; init; } 
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Indicates if a counterparty rating trigger is agreed by the counterparties for the collateral posted by the reporting counterparty.
    /// Usage: If the element is not present, the CounterpartyRatingTrigger is False.
    /// </summary>
    public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; } 
    /// <summary>
    /// Indicates if a counterparty rating trigger includes a threshold that increases collateral requirements when the counterparty falls below the single-A rating or equivalent.
    /// Usage: If the CounterpartyRatingTrigger indicator is false, this element is omitted.
    /// </summary>
    public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes6? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (ReportingTimeStamp is IsoISODateTime ReportingTimeStampValue)
        {
            writer.WriteStartElement(null, "RptgTmStmp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ReportingTimeStampValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CtrPtyId", xmlNamespace );
        CounterpartyIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (EventDate is IsoISODate EventDateValue)
        {
            writer.WriteStartElement(null, "EvtDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(EventDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TransactionIdentification is UniqueTransactionIdentifier2Choice_ TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            TransactionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Coll", xmlNamespace );
        Collateral.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PostedMarginOrCollateral is PostedMarginOrCollateral6 PostedMarginOrCollateralValue)
        {
            writer.WriteStartElement(null, "PstdMrgnOrColl", xmlNamespace );
            PostedMarginOrCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivedMarginOrCollateral is ReceivedMarginOrCollateral6 ReceivedMarginOrCollateralValue)
        {
            writer.WriteStartElement(null, "RcvdMrgnOrColl", xmlNamespace );
            ReceivedMarginOrCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CounterpartyRatingTriggerIndicator is IsoTrueFalseIndicator CounterpartyRatingTriggerIndicatorValue)
        {
            writer.WriteStartElement(null, "CtrPtyRatgTrggrInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CounterpartyRatingTriggerIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (CounterpartyRatingThresholdIndicator is IsoTrueFalseIndicator CounterpartyRatingThresholdIndicatorValue)
        {
            writer.WriteStartElement(null, "CtrPtyRatgThrshldInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CounterpartyRatingThresholdIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (TechnicalAttributes is TechnicalAttributes6 TechnicalAttributesValue)
        {
            writer.WriteStartElement(null, "TechAttrbts", xmlNamespace );
            TechnicalAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Correction Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
