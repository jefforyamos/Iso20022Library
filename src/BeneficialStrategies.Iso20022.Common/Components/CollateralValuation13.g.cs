﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralValuation13.  ISO2002 ID# _eJF90SqUEeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation details of each piece of collateral posted.
/// </summary>
public partial record CollateralValuation13
     : IIsoXmlSerilizable<CollateralValuation13>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the valued collateral.
    /// </summary>
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Type of collateral used.
    /// </summary>
    public required CollateralType8Code CollateralType { get; init; } 
    /// <summary>
    /// Direction of the collateral being reported.
    /// </summary>
    public CollateralDirection1Code? CollateralDirection { get; init; } 
    /// <summary>
    /// Settlement status of the instruction/financial instrument movement.
    /// </summary>
    public required SettlementStatus3Code SettlementStatus { get; init; } 
    /// <summary>
    /// Indicates if the collateral being reported is applied or in excess.
    /// </summary>
    public CollateralAppliedExcess1Code? AppliedExcessIndicator { get; init; } 
    /// <summary>
    /// Number of days used for interest calculation.
    /// </summary>
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Details of the collateral valuation.
    /// </summary>
    public required CollateralAmount1 ValuationAmounts { get; init; } 
    /// <summary>
    /// Computation method of (accrued) interest of the security.
    /// </summary>
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    /// <summary>
    /// Exchange rate between the currency of the collateral and the reporting currency.
    /// </summary>
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the currency of the collateral expressed as a percentage.
    /// </summary>
    public IsoBaseOneRate? CurrencyHaircut { get; init; } 
    /// <summary>
    /// Percentage by which the collateral amount needs to be adjusted.
    /// </summary>
    public IsoBaseOneRate? AdjustedRate { get; init; } 
    /// <summary>
    /// Provides details on the securities collateral.
    /// </summary>
    public SecuritiesCollateral13? SecuritiesCollateral { get; init; } 
    /// <summary>
    /// Details of the cash collateral valuation.
    /// </summary>
    public CashCollateral4? CashCollateral { get; init; } 
    /// <summary>
    /// Details of other collateral.
    /// </summary>
    public OtherCollateral10? OtherCollateral { get; init; } 
    
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
        if (CollateralIdentification is IsoMax35Text CollateralIdentificationValue)
        {
            writer.WriteStartElement(null, "CollId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CollateralIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CollTp", xmlNamespace );
        writer.WriteValue(CollateralType.ToString()); // Enum value
        writer.WriteEndElement();
        if (CollateralDirection is CollateralDirection1Code CollateralDirectionValue)
        {
            writer.WriteStartElement(null, "CollDrctn", xmlNamespace );
            writer.WriteValue(CollateralDirectionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmSts", xmlNamespace );
        writer.WriteValue(SettlementStatus.ToString()); // Enum value
        writer.WriteEndElement();
        if (AppliedExcessIndicator is CollateralAppliedExcess1Code AppliedExcessIndicatorValue)
        {
            writer.WriteStartElement(null, "ApldXcssInd", xmlNamespace );
            writer.WriteValue(AppliedExcessIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NumberOfDaysAccrued is IsoNumber NumberOfDaysAccruedValue)
        {
            writer.WriteStartElement(null, "NbOfDaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfDaysAccruedValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ValtnAmts", xmlNamespace );
        ValuationAmounts.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DayCountBasis is InterestComputationMethod2Code DayCountBasisValue)
        {
            writer.WriteStartElement(null, "DayCntBsis", xmlNamespace );
            writer.WriteValue(DayCountBasisValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ExchangeRate is IsoBaseOneRate ExchangeRateValue)
        {
            writer.WriteStartElement(null, "XchgRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRateValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (CurrencyHaircut is IsoBaseOneRate CurrencyHaircutValue)
        {
            writer.WriteStartElement(null, "CcyHrcut", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(CurrencyHaircutValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (AdjustedRate is IsoBaseOneRate AdjustedRateValue)
        {
            writer.WriteStartElement(null, "AdjstdRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(AdjustedRateValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (SecuritiesCollateral is SecuritiesCollateral13 SecuritiesCollateralValue)
        {
            writer.WriteStartElement(null, "SctiesColl", xmlNamespace );
            SecuritiesCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashCollateral is CashCollateral4 CashCollateralValue)
        {
            writer.WriteStartElement(null, "CshColl", xmlNamespace );
            CashCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherCollateral is OtherCollateral10 OtherCollateralValue)
        {
            writer.WriteStartElement(null, "OthrColl", xmlNamespace );
            OtherCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CollateralValuation13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
