﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOptionSD10.  ISO2002 ID# __sbHQZCMEeaSk9d1hvTrHg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
public partial record CashOptionSD10
     : IIsoXmlSerilizable<CashOptionSD10>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    public required DTCCPayoutType5Code PayoutType { get; init; } 
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3Text? DTCPayMethod { get; init; } 
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3Text? DTCPayOrder { get; init; } 
    /// <summary>
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    /// <summary>
    /// Identifies the income events which are subject to withholding tax if paid to a non-U.S. resident alien (NRA).
    /// </summary>
    public IsoYesNoIndicator? NRATaxReportableFlag { get; init; } 
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to "no" changes are due when protect is covered.
    /// </summary>
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    /// <summary>
    /// Cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    public PriceFormatSD2Choice_? DeclaredCashRate { get; init; } 
    /// <summary>
    /// Gross cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    public PriceFormatSD2Choice_? DeclaredGrossRate { get; init; } 
    /// <summary>
    /// Net cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    public PriceFormatSD2Choice_? DeclaredNetRate { get; init; } 
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    public PriceFormatSD2Choice_? DeclaredFeeRate { get; init; } 
    /// <summary>
    /// Indicates the period during which the instructions for DTC (The Depository Trust Corporation) US Tax service will be accepted.
    /// </summary>
    public Period3? DTCUSTaxInstructionPeriod { get; init; } 
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
        writer.WriteStartElement(null, "PyoutTp", xmlNamespace );
        writer.WriteValue(PayoutType.ToString()); // Enum value
        writer.WriteEndElement();
        if (DTCPayMethod is IsoMax3Text DTCPayMethodValue)
        {
            writer.WriteStartElement(null, "DTCPayMtd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Text(DTCPayMethodValue)); // data type Max3Text System.String
            writer.WriteEndElement();
        }
        if (DTCPayOrder is IsoMax3Text DTCPayOrderValue)
        {
            writer.WriteStartElement(null, "DTCPayOrdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Text(DTCPayOrderValue)); // data type Max3Text System.String
            writer.WriteEndElement();
        }
        if (EntitlementCalculationMethod is DTCEntitlementCalculationMethod1Code EntitlementCalculationMethodValue)
        {
            writer.WriteStartElement(null, "EntitlmntClctnMtd", xmlNamespace );
            writer.WriteValue(EntitlementCalculationMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (EstimatedRateFlag is IsoYesNoIndicator EstimatedRateFlagValue)
        {
            writer.WriteStartElement(null, "EstmtdRateFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(EstimatedRateFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (NRATaxReportableFlag is IsoYesNoIndicator NRATaxReportableFlagValue)
        {
            writer.WriteStartElement(null, "NRATaxRptblFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(NRATaxReportableFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ProtectChargeFlag is IsoYesNoIndicator ProtectChargeFlagValue)
        {
            writer.WriteStartElement(null, "PrtctChrgFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ProtectChargeFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (DeclaredCashRate is PriceFormatSD2Choice_ DeclaredCashRateValue)
        {
            writer.WriteStartElement(null, "DclrdCshRate", xmlNamespace );
            DeclaredCashRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeclaredGrossRate is PriceFormatSD2Choice_ DeclaredGrossRateValue)
        {
            writer.WriteStartElement(null, "DclrdGrssRate", xmlNamespace );
            DeclaredGrossRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeclaredNetRate is PriceFormatSD2Choice_ DeclaredNetRateValue)
        {
            writer.WriteStartElement(null, "DclrdNetRate", xmlNamespace );
            DeclaredNetRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeclaredFeeRate is PriceFormatSD2Choice_ DeclaredFeeRateValue)
        {
            writer.WriteStartElement(null, "DclrdFeeRate", xmlNamespace );
            DeclaredFeeRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DTCUSTaxInstructionPeriod is Period3 DTCUSTaxInstructionPeriodValue)
        {
            writer.WriteStartElement(null, "DTCUSTaxInstrPrd", xmlNamespace );
            DTCUSTaxInstructionPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RDPReferenceNumber is IsoExact32AlphaNumericText RDPReferenceNumberValue)
        {
            writer.WriteStartElement(null, "RDPRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact32AlphaNumericText(RDPReferenceNumberValue)); // data type Exact32AlphaNumericText System.String
            writer.WriteEndElement();
        }
    }
    public static CashOptionSD10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
