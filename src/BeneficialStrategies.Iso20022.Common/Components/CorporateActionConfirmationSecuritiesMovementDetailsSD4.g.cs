﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionConfirmationSecuritiesMovementDetailsSD4.  ISO2002 ID# _igOf4Z2GEeW-bsa36JFb9A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action confirmation securities movement details.
/// </summary>
public partial record CorporateActionConfirmationSecuritiesMovementDetailsSD4
     : IIsoXmlSerilizable<CorporateActionConfirmationSecuritiesMovementDetailsSD4>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    public required DTCCPayoutType4Code PayoutType { get; init; } 
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    /// <summary>
    /// Transaction reason.
    /// </summary>
    public DTCAdjustmentPaymentType2Code? ReasonCode { get; init; } 
    /// <summary>
    /// Transaction sub reason.
    /// </summary>
    public DTCAdjustmentPaymentSubReason1Code? SubReasonCode { get; init; } 
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Date/Time on which the posting /draft of the securities took place.
    /// </summary>
    public DateFormat28Choice_? PostingDate { get; init; } 
    /// <summary>
    /// Set of the DTC legacy sub reason codes representing tax rate. Used with reason codes ‘TJXD’ ‘TJXF’ ‘TJXI’ ‘TJXL’ ‘TJXR’ ‘TJXT’ ‘TJXU’ to identify the correct tax rate.
    /// </summary>
    public IsoPercentageRate? TaxAdjustmentRate { get; init; } 
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (Event Details, Options, Movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related Activity Types 74, and 54. If event details and cash option are sourced from the Activity Type 74, then Activity Type 74 will be in RDP Reference Number in event details, and also on the cash option. The activity type 54 will be "on" the security option. Also, usage rules will specify the different layouts of the RDP Reference Number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
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
        writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndName)); // data type Max350Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PyoutTp", xmlNamespace );
        writer.WriteValue(PayoutType.ToString()); // Enum value
        writer.WriteEndElement();
        if (TransactionQuantity is FinancialInstrumentQuantity15Choice_ TransactionQuantityValue)
        {
            writer.WriteStartElement(null, "TxQty", xmlNamespace );
            TransactionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReasonCode is DTCAdjustmentPaymentType2Code ReasonCodeValue)
        {
            writer.WriteStartElement(null, "RsnCd", xmlNamespace );
            writer.WriteValue(ReasonCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SubReasonCode is DTCAdjustmentPaymentSubReason1Code SubReasonCodeValue)
        {
            writer.WriteStartElement(null, "SubRsnCd", xmlNamespace );
            writer.WriteValue(SubReasonCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ContraParticipantNumber is IsoMax8Text ContraParticipantNumberValue)
        {
            writer.WriteStartElement(null, "ContraPtcptNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax8Text(ContraParticipantNumberValue)); // data type Max8Text System.String
            writer.WriteEndElement();
        }
        if (MaturityDate is IsoISODate MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (PostingDate is DateFormat28Choice_ PostingDateValue)
        {
            writer.WriteStartElement(null, "PstngDt", xmlNamespace );
            PostingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxAdjustmentRate is IsoPercentageRate TaxAdjustmentRateValue)
        {
            writer.WriteStartElement(null, "TaxAdjstmntRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(TaxAdjustmentRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (RDPReferenceNumber is IsoExact32AlphaNumericText RDPReferenceNumberValue)
        {
            writer.WriteStartElement(null, "RDPRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact32AlphaNumericText(RDPReferenceNumberValue)); // data type Exact32AlphaNumericText System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionConfirmationSecuritiesMovementDetailsSD4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
