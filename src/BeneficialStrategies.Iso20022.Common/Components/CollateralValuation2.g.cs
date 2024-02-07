﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralValuation2.  ISO2002 ID# _7ZNbl2A4EeSMf75YyPqG7w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the valuation of each piece of collateral that is posted.
/// </summary>
public partial record CollateralValuation2
     : IIsoXmlSerilizable<CollateralValuation2>
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the valued collateral.
    /// </summary>
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of collateral used.
    /// </summary>
    public required CollateralType1Code CollateralType { get; init; } 
    /// <summary>
    /// Provides the status of settlement of an instruction/financial instrument movement.
    /// </summary>
    public required SettlementStatus2Code SettlementStatus { get; init; } 
    /// <summary>
    /// Specifies the number of days used for interest calculation.
    /// </summary>
    public required IsoNumber NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    public required CollateralAmount1 ValuationAmounts { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    public required InterestComputationMethod2Code DayCountBasis { get; init; } 
    /// <summary>
    /// Specifies the exchange rate between the currency of the collateral and the reporting currency.
    /// </summary>
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    /// <summary>
    /// Specifies the haircut or valuation factor on the currency of the collateral expressed as a percentage.
    /// </summary>
    public IsoBaseOneRate? CurrencyHaircut { get; init; } 
    /// <summary>
    /// Percentage by which the collateral amount needs to be adjusted.
    /// </summary>
    public IsoBaseOneRate? AdjustedRate { get; init; } 
    /// <summary>
    /// Provides details on the securities collateral.
    /// </summary>
    public SecuritiesCollateral2? SecuritiesCollateral { get; init; } 
    /// <summary>
    /// Provides details on the cash collateral valuation.
    /// </summary>
    public CashCollateral4? CashCollateral { get; init; } 
    /// <summary>
    /// Provides details on other collateral valuation.
    /// </summary>
    public OtherCollateral3? OtherCollateral { get; init; } 
    
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
        writer.WriteStartElement(null, "SttlmSts", xmlNamespace );
        writer.WriteValue(SettlementStatus.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NbOfDaysAcrd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfDaysAccrued)); // data type Number System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ValtnAmts", xmlNamespace );
        ValuationAmounts.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DayCntBsis", xmlNamespace );
        writer.WriteValue(DayCountBasis.ToString()); // Enum value
        writer.WriteEndElement();
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
        if (SecuritiesCollateral is SecuritiesCollateral2 SecuritiesCollateralValue)
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
        if (OtherCollateral is OtherCollateral3 OtherCollateralValue)
        {
            writer.WriteStartElement(null, "OthrColl", xmlNamespace );
            OtherCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CollateralValuation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
