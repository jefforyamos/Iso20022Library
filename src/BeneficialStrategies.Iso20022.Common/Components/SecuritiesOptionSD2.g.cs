﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOptionSD2.  ISO2002 ID# _1kD7cDL3EeKU9IrkkToqcw_2008778230.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement details.
/// </summary>
public partial record SecuritiesOptionSD2
     : IIsoXmlSerilizable<SecuritiesOptionSD2>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC(The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3NumericText? DTCPayMethod { get; init; } 
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3NumericText? DTCPayOrder { get; init; } 
    /// <summary>
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    public ReinvestmentIncomeClassification1Code? ReinvestmentIncomeClassification { get; init; } 
    /// <summary>
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    /// <summary>
    /// Price is based on either base or disbursed security.
    /// </summary>
    public DTCBaseDisbursed1Code? PriceBasis { get; init; } 
    /// <summary>
    /// Specifies the reason for DTC (The Depository Trust Corporation) to exit the shares.
    /// </summary>
    public SecuritiesExitReason1Code? DTCExitExplanationIndicator { get; init; } 
    /// <summary>
    /// Indicates whether a DTC (The Depository Trust Corporation) participant, using one or more payment bonds in connection with a warrant exercise, will be charged (through settlement on exercise date) the value of the upcoming interest payment on the bond(s).
    /// </summary>
    public IsoYesNoIndicator? ChargeFlag { get; init; } 
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to "no" changes are due when protect is covered.
    /// </summary>
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    /// <summary>
    /// Indicates whether the price from the offeror is estimated or final.
    /// </summary>
    public IsoYesNoIndicator? EstimatedPriceFlag { get; init; } 
    /// <summary>
    /// Time period during which instructions regarding the disposition of fractional entitlements will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    public Period3? DTCFractionalShareInstructionPeriod { get; init; } 
    /// <summary>
    /// Indicates the period during which the instructions for US Tax service will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    public Period3? DTCUSTaxInstructionPeriod { get; init; } 
    
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
        if (DTCPayMethod is IsoMax3NumericText DTCPayMethodValue)
        {
            writer.WriteStartElement(null, "DTCPayMtd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(DTCPayMethodValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (DTCPayOrder is IsoMax3NumericText DTCPayOrderValue)
        {
            writer.WriteStartElement(null, "DTCPayOrdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(DTCPayOrderValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (ReinvestmentIncomeClassification is ReinvestmentIncomeClassification1Code ReinvestmentIncomeClassificationValue)
        {
            writer.WriteStartElement(null, "RinvstmtIncmClssfctn", xmlNamespace );
            writer.WriteValue(ReinvestmentIncomeClassificationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (EntitlementCalculationMethod is DTCEntitlementCalculationMethod1Code EntitlementCalculationMethodValue)
        {
            writer.WriteStartElement(null, "EntitlmntClctnMtd", xmlNamespace );
            writer.WriteValue(EntitlementCalculationMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PriceBasis is DTCBaseDisbursed1Code PriceBasisValue)
        {
            writer.WriteStartElement(null, "PricBsis", xmlNamespace );
            writer.WriteValue(PriceBasisValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DTCExitExplanationIndicator is SecuritiesExitReason1Code DTCExitExplanationIndicatorValue)
        {
            writer.WriteStartElement(null, "DTCExitExpltnInd", xmlNamespace );
            writer.WriteValue(DTCExitExplanationIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChargeFlag is IsoYesNoIndicator ChargeFlagValue)
        {
            writer.WriteStartElement(null, "ChrgFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ChargeFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ProtectChargeFlag is IsoYesNoIndicator ProtectChargeFlagValue)
        {
            writer.WriteStartElement(null, "PrtctChrgFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ProtectChargeFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (EstimatedPriceFlag is IsoYesNoIndicator EstimatedPriceFlagValue)
        {
            writer.WriteStartElement(null, "EstmtdPricFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(EstimatedPriceFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (DTCFractionalShareInstructionPeriod is Period3 DTCFractionalShareInstructionPeriodValue)
        {
            writer.WriteStartElement(null, "DTCFrctnlShrInstrPrd", xmlNamespace );
            DTCFractionalShareInstructionPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DTCUSTaxInstructionPeriod is Period3 DTCUSTaxInstructionPeriodValue)
        {
            writer.WriteStartElement(null, "DTCUSTaxInstrPrd", xmlNamespace );
            DTCUSTaxInstructionPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesOptionSD2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
