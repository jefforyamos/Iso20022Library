﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Drawdown1.  ISO2002 ID# _9IEgwFNcEeijdq8ilaxyOA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a drawdown tranche.
/// </summary>
public partial record Drawdown1
     : IIsoXmlSerilizable<Drawdown1>
{
    #nullable enable
    
    /// <summary>
    /// Type of drawdown tranche.
    /// </summary>
    public required DrawdownType1Choice_ TrancheType { get; init; } 
    /// <summary>
    /// Specifies the rules that are applicable to the drawdown. For example, in the UK market, the pre-A-day rule that was introduced on 6 April 2006.)
    /// </summary>
    public ApplicableRules1Choice_? ApplicableRules { get; init; } 
    /// <summary>
    /// Percentage of the total transfer value covered by the drawdown.
    /// </summary>
    public IsoPercentageRate? PercentageOfTotalTransferValue { get; init; } 
    /// <summary>
    /// Amount that was originally designated for drawdown.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? TotalAmountNetDrawdown { get; init; } 
    /// <summary>
    /// Indicates whether any additional funds have been designated since the original arrangement.
    /// </summary>
    public IsoYesNoIndicator? AdditionalFundsDesignated { get; init; } 
    /// <summary>
    /// Drawdown allowance check. For pensions that have a lifetime allowance, a check is made of the maximum value of benefits that may be taken from the pension without incurring a special tax. (This check or 'event' is known as the benefit crystallisation event in the UK market.)
    /// </summary>
    public DrawdownAllowanceCheck1? DrawdownAllowanceCheck { get; init; } 
    /// <summary>
    /// Amount of the pension commencement lump sum (PCLS) remaining.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? PensionCommencementLumpSumRemaining { get; init; } 
    /// <summary>
    /// Date by which the pension commencement lump sum (PCLS) must be used.
    /// </summary>
    public IsoISODate? PensionCommencementLumpSumDate { get; init; } 
    /// <summary>
    /// Indicates there have been multiple pension commencement lump sum (PCLS) payments. 
    /// </summary>
    public IsoYesNoIndicator? MultiplePensionCommencementLumpSums { get; init; } 
    /// <summary>
    /// Percentage of the lifetime allowance (LTA) used.
    /// </summary>
    public IsoPercentageRate? LifetimeAllowance { get; init; } 
    /// <summary>
    /// Indicates a person other than the original pension holder is the receiver of the drawdown payment.
    /// </summary>
    public IsoYesNoIndicator? RecipientOfDrawdownIndicator { get; init; } 
    /// <summary>
    /// Information about the recipient of the drawdown, when not the original pension holder.
    /// </summary>
    public BeneficiaryDrawdown1? BeneficiaryDetails { get; init; } 
    /// <summary>
    /// Limits of the capped drawdown.
    /// </summary>
    public Capped1? CappedLimits { get; init; } 
    /// <summary>
    /// Date on which the drawdown was triggered when the drawdown type is flexible.
    /// </summary>
    public IsoISODate? FlexibleDrawdownTriggeredDate { get; init; } 
    /// <summary>
    /// Additional information about the drawdown.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "TrchTp", xmlNamespace );
        TrancheType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ApplicableRules is ApplicableRules1Choice_ ApplicableRulesValue)
        {
            writer.WriteStartElement(null, "AplblRules", xmlNamespace );
            ApplicableRulesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PercentageOfTotalTransferValue is IsoPercentageRate PercentageOfTotalTransferValueValue)
        {
            writer.WriteStartElement(null, "PctgOfTtlTrfVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(PercentageOfTotalTransferValueValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (TotalAmountNetDrawdown is IsoActiveCurrencyAnd13DecimalAmount TotalAmountNetDrawdownValue)
        {
            writer.WriteStartElement(null, "TtlAmtNetDrwdwn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(TotalAmountNetDrawdownValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AdditionalFundsDesignated is IsoYesNoIndicator AdditionalFundsDesignatedValue)
        {
            writer.WriteStartElement(null, "AddtlFndsDsgntd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(AdditionalFundsDesignatedValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (DrawdownAllowanceCheck is DrawdownAllowanceCheck1 DrawdownAllowanceCheckValue)
        {
            writer.WriteStartElement(null, "DrwdwnAllwncChck", xmlNamespace );
            DrawdownAllowanceCheckValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PensionCommencementLumpSumRemaining is IsoActiveCurrencyAnd13DecimalAmount PensionCommencementLumpSumRemainingValue)
        {
            writer.WriteStartElement(null, "PnsnCmcmntLumpSumRmng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(PensionCommencementLumpSumRemainingValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PensionCommencementLumpSumDate is IsoISODate PensionCommencementLumpSumDateValue)
        {
            writer.WriteStartElement(null, "PnsnCmcmntLumpSumDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(PensionCommencementLumpSumDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (MultiplePensionCommencementLumpSums is IsoYesNoIndicator MultiplePensionCommencementLumpSumsValue)
        {
            writer.WriteStartElement(null, "MltplPnsnCmcmntLumpSums", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(MultiplePensionCommencementLumpSumsValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (LifetimeAllowance is IsoPercentageRate LifetimeAllowanceValue)
        {
            writer.WriteStartElement(null, "LftmAllwnc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(LifetimeAllowanceValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (RecipientOfDrawdownIndicator is IsoYesNoIndicator RecipientOfDrawdownIndicatorValue)
        {
            writer.WriteStartElement(null, "RcptOfDrwdwnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(RecipientOfDrawdownIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (BeneficiaryDetails is BeneficiaryDrawdown1 BeneficiaryDetailsValue)
        {
            writer.WriteStartElement(null, "BnfcryDtls", xmlNamespace );
            BeneficiaryDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CappedLimits is Capped1 CappedLimitsValue)
        {
            writer.WriteStartElement(null, "CapdLmts", xmlNamespace );
            CappedLimitsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FlexibleDrawdownTriggeredDate is IsoISODate FlexibleDrawdownTriggeredDateValue)
        {
            writer.WriteStartElement(null, "FlxblDrwdwnTrggrdDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FlexibleDrawdownTriggeredDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Drawdown1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
