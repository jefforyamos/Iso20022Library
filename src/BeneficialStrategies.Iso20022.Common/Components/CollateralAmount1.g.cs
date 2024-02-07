﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralAmount1.  ISO2002 ID# _vWhlQ6MOEeCojJW5vEuTEQ_1855607436.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the collateral valuation such as the collateral amount, the market value.
/// </summary>
public partial record CollateralAmount1
     : IIsoXmlSerilizable<CollateralAmount1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total amount of the collateral in the collateral currency.
    /// </summary>
    public required IsoActiveCurrencyAndAmount CollateralAmount { get; init; } 
    /// <summary>
    /// Specifies the total amount of the collateral in the reporting currency.
    /// </summary>
    public required IsoActiveCurrencyAndAmount ReportedCurrencyAndAmount { get; init; } 
    /// <summary>
    /// Specifies the total market to market value of the collateral in the reporting currency. It is the dirty price, that is, the accrued interest is included if any.
    /// </summary>
    public required IsoActiveCurrencyAndAmount MarketValueAmount { get; init; } 
    /// <summary>
    /// Specifies the accrued interest on the value of the collateral in the currency of the collateral.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Specifies the amount of money paid for the provision of financial services.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FeesAndCommissions { get; init; } 
    
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
        writer.WriteStartElement(null, "CollAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CollateralAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptdCcyAndAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ReportedCurrencyAndAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MktValAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(MarketValueAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (AccruedInterestAmount is IsoActiveCurrencyAndAmount AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AccruedInterestAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FeesAndCommissions is IsoActiveCurrencyAndAmount FeesAndCommissionsValue)
        {
            writer.WriteStartElement(null, "FeesAndComssns", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(FeesAndCommissionsValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static CollateralAmount1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
