﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesFinancingTransactionDetails32.  ISO2002 ID# _5-BguZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
public partial record SecuritiesFinancingTransactionDetails32
     : IIsoXmlSerilizable<SecuritiesFinancingTransactionDetails32>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    public IsoRestrictedFINXMax16Text? SecuritiesFinancingTradeIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClosingLegIdentification { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public TerminationDate5Choice_? TerminationDate { get; init; } 
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    public DateAndDateTimeChoice_? RateChangeDate { get; init; } 
    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    public DateAndDateTimeChoice_? EarliestCallBackDate { get; init; } 
    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    public DateAndDateTimeChoice_? CommissionCalculationDate { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    public RateType67Choice_? RateType { get; init; } 
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    public RevaluationIndicator4Choice_? Revaluation { get; init; } 
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    public LegalFramework4Choice_? LegalFramework { get; init; } 
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; init; } 
    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 
    /// <summary>
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    public IsoYesNoIndicator? InterestPayment { get; init; } 
    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    public RateName2? VariableRateSupport { get; init; } 
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    public Rate2? RepurchaseRate { get; init; } 
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender's risk.
    /// </summary>
    public Rate2? StockLoanMargin { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    public Rate2? SecuritiesHaircut { get; init; } 
    /// <summary>
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    public Rate2? ChargesRate { get; init; } 
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    public RateOrName2Choice_? PricingRate { get; init; } 
    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    public Rate2? Spread { get; init; } 
    /// <summary>
    /// Minimum number of days' notice a counterparty needs for terminating the transaction.
    /// </summary>
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 
    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    public AmountAndDirection59? LocalBrokerCommission { get; init; } 
    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    public AmountAndDirection59? DealAmount { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    public AmountAndDirection59? ForfeitAmount { get; init; } 
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    public AmountAndDirection59? PremiumAmount { get; init; } 
    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; init; } 
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    public IsoRestrictedFINXMax140Text? SecondLegNarrative { get; init; } 
    
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
        if (SecuritiesFinancingTradeIdentification is IsoRestrictedFINXMax16Text SecuritiesFinancingTradeIdentificationValue)
        {
            writer.WriteStartElement(null, "SctiesFincgTradId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(SecuritiesFinancingTradeIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClosingLegIdentification is IsoRestrictedFINXMax16Text ClosingLegIdentificationValue)
        {
            writer.WriteStartElement(null, "ClsgLegId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClosingLegIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TerminationDate is TerminationDate5Choice_ TerminationDateValue)
        {
            writer.WriteStartElement(null, "TermntnDt", xmlNamespace );
            TerminationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateChangeDate is DateAndDateTimeChoice_ RateChangeDateValue)
        {
            writer.WriteStartElement(null, "RateChngDt", xmlNamespace );
            RateChangeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EarliestCallBackDate is DateAndDateTimeChoice_ EarliestCallBackDateValue)
        {
            writer.WriteStartElement(null, "EarlstCallBckDt", xmlNamespace );
            EarliestCallBackDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CommissionCalculationDate is DateAndDateTimeChoice_ CommissionCalculationDateValue)
        {
            writer.WriteStartElement(null, "ComssnClctnDt", xmlNamespace );
            CommissionCalculationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateType is RateType67Choice_ RateTypeValue)
        {
            writer.WriteStartElement(null, "RateTp", xmlNamespace );
            RateTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Revaluation is RevaluationIndicator4Choice_ RevaluationValue)
        {
            writer.WriteStartElement(null, "Rvaltn", xmlNamespace );
            RevaluationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalFramework is LegalFramework4Choice_ LegalFrameworkValue)
        {
            writer.WriteStartElement(null, "LglFrmwk", xmlNamespace );
            LegalFrameworkValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterestComputationMethod is InterestComputationMethodFormat5Choice_ InterestComputationMethodValue)
        {
            writer.WriteStartElement(null, "IntrstCmptnMtd", xmlNamespace );
            InterestComputationMethodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MaturityDateModification is IsoYesNoIndicator MaturityDateModificationValue)
        {
            writer.WriteStartElement(null, "MtrtyDtMod", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(MaturityDateModificationValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (InterestPayment is IsoYesNoIndicator InterestPaymentValue)
        {
            writer.WriteStartElement(null, "IntrstPmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(InterestPaymentValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (VariableRateSupport is RateName2 VariableRateSupportValue)
        {
            writer.WriteStartElement(null, "VarblRateSpprt", xmlNamespace );
            VariableRateSupportValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepurchaseRate is Rate2 RepurchaseRateValue)
        {
            writer.WriteStartElement(null, "RpRate", xmlNamespace );
            RepurchaseRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StockLoanMargin is Rate2 StockLoanMarginValue)
        {
            writer.WriteStartElement(null, "StockLnMrgn", xmlNamespace );
            StockLoanMarginValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesHaircut is Rate2 SecuritiesHaircutValue)
        {
            writer.WriteStartElement(null, "SctiesHrcut", xmlNamespace );
            SecuritiesHaircutValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesRate is Rate2 ChargesRateValue)
        {
            writer.WriteStartElement(null, "ChrgsRate", xmlNamespace );
            ChargesRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PricingRate is RateOrName2Choice_ PricingRateValue)
        {
            writer.WriteStartElement(null, "PricgRate", xmlNamespace );
            PricingRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Spread is Rate2 SpreadValue)
        {
            writer.WriteStartElement(null, "Sprd", xmlNamespace );
            SpreadValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionCallDelay is IsoExact3NumericText TransactionCallDelayValue)
        {
            writer.WriteStartElement(null, "TxCallDely", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact3NumericText(TransactionCallDelayValue)); // data type Exact3NumericText System.String
            writer.WriteEndElement();
        }
        if (TotalNumberOfCollateralInstructions is IsoExact3NumericText TotalNumberOfCollateralInstructionsValue)
        {
            writer.WriteStartElement(null, "TtlNbOfCollInstrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact3NumericText(TotalNumberOfCollateralInstructionsValue)); // data type Exact3NumericText System.String
            writer.WriteEndElement();
        }
        if (LocalBrokerCommission is AmountAndDirection59 LocalBrokerCommissionValue)
        {
            writer.WriteStartElement(null, "LclBrkrComssn", xmlNamespace );
            LocalBrokerCommissionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DealAmount is AmountAndDirection59 DealAmountValue)
        {
            writer.WriteStartElement(null, "DealAmt", xmlNamespace );
            DealAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccruedInterestAmount is AmountAndDirection59 AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            AccruedInterestAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForfeitAmount is AmountAndDirection59 ForfeitAmountValue)
        {
            writer.WriteStartElement(null, "FrftAmt", xmlNamespace );
            ForfeitAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PremiumAmount is AmountAndDirection59 PremiumAmountValue)
        {
            writer.WriteStartElement(null, "PrmAmt", xmlNamespace );
            PremiumAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminationAmountPerPieceOfCollateral is AmountAndDirection59 TerminationAmountPerPieceOfCollateralValue)
        {
            writer.WriteStartElement(null, "TermntnAmtPerPcOfColl", xmlNamespace );
            TerminationAmountPerPieceOfCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminationTransactionAmount is AmountAndDirection59 TerminationTransactionAmountValue)
        {
            writer.WriteStartElement(null, "TermntnTxAmt", xmlNamespace );
            TerminationTransactionAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondLegNarrative is IsoRestrictedFINXMax140Text SecondLegNarrativeValue)
        {
            writer.WriteStartElement(null, "ScndLegNrrtv", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax140Text(SecondLegNarrativeValue)); // data type RestrictedFINXMax140Text System.String
            writer.WriteEndElement();
        }
    }
    public static SecuritiesFinancingTransactionDetails32 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
