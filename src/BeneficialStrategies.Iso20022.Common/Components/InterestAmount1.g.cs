﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestAmount1.  ISO2002 ID# _SRKvZNp-Ed-ak6NoX_4Aeg_1143033565.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the elements related to the interest amount calculation.
/// </summary>
public partial record InterestAmount1
     : IIsoXmlSerilizable<InterestAmount1>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the interest request is new or updated.
    /// </summary>
    public required InterestRequestSequence1Code InterestRequestSequence { get; init; } 
    /// <summary>
    /// Period for which the calculation has been performed.
    /// </summary>
    public required DatePeriodDetails InterestPeriod { get; init; } 
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    public required IsoActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    public required IsoISODate ValueDate { get; init; } 
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    public required InterestMethod1Code InterestMethod { get; init; } 
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    public InterestRate1Choice_? InterestRate { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    public IsoYesNoIndicator? AppliedWithholdingTax { get; init; } 
    /// <summary>
    /// Specifies whether the interest is simple or compounded.
    /// </summary>
    public CalculationMethod1Code? CalculationMethod { get; init; } 
    /// <summary>
    /// Specifies the periodicity of the calculation of the interest.
    /// </summary>
    public Frequency1Code? CalculationFrequency { get; init; } 
    /// <summary>
    /// Specifies whether the collateral has been posted against the variation margin, the segregated independent amount or to cover any other risk defined with a proprietary code.
    /// </summary>
    public required CollateralPurpose1Choice_ CollateralPurpose { get; init; } 
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    /// <summary>
    /// Additionnal information related to interest request.
    /// </summary>
    public IsoMax210Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Additional references linked to the updated interest payement request.
    /// </summary>
    public Reference20? ReferenceDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "IntrstReqSeq", xmlNamespace );
        writer.WriteValue(InterestRequestSequence.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrstPrd", xmlNamespace );
        InterestPeriod.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AccruedInterestAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ValDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ValueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrstMtd", xmlNamespace );
        writer.WriteValue(InterestMethod.ToString()); // Enum value
        writer.WriteEndElement();
        if (InterestRate is InterestRate1Choice_ InterestRateValue)
        {
            writer.WriteStartElement(null, "IntrstRate", xmlNamespace );
            InterestRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DayCountBasis is InterestComputationMethod2Code DayCountBasisValue)
        {
            writer.WriteStartElement(null, "DayCntBsis", xmlNamespace );
            writer.WriteValue(DayCountBasisValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AppliedWithholdingTax is IsoYesNoIndicator AppliedWithholdingTaxValue)
        {
            writer.WriteStartElement(null, "ApldWhldgTax", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(AppliedWithholdingTaxValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CalculationMethod is CalculationMethod1Code CalculationMethodValue)
        {
            writer.WriteStartElement(null, "ClctnMtd", xmlNamespace );
            writer.WriteValue(CalculationMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CalculationFrequency is Frequency1Code CalculationFrequencyValue)
        {
            writer.WriteStartElement(null, "ClctnFrqcy", xmlNamespace );
            writer.WriteValue(CalculationFrequencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CollPurp", xmlNamespace );
        CollateralPurpose.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OpeningCollateralBalance is CollateralBalance1 OpeningCollateralBalanceValue)
        {
            writer.WriteStartElement(null, "OpngCollBal", xmlNamespace );
            OpeningCollateralBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ClsgCollBal", xmlNamespace );
        ClosingCollateralBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (StandardSettlementInstructions is IsoMax140Text StandardSettlementInstructionsValue)
        {
            writer.WriteStartElement(null, "StdSttlmInstrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(StandardSettlementInstructionsValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax210Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax210Text(AdditionalInformationValue)); // data type Max210Text System.String
            writer.WriteEndElement();
        }
        if (ReferenceDetails is Reference20 ReferenceDetailsValue)
        {
            writer.WriteStartElement(null, "RefDtls", xmlNamespace );
            ReferenceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InterestAmount1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
