﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExposureMetrics4.  ISO2002 ID# _nh43Ya5MEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on market exposures.
/// </summary>
public partial record ExposureMetrics4
     : IIsoXmlSerilizable<ExposureMetrics4>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    /// <summary>
    /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    public AmountAndDirection53? MarketValue { get; init; } 
    /// <summary>
    /// Total amount of margin loans in base currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
    /// <summary>
    /// Market value of short position in base currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
    /// <summary>
    /// Margin loan in which a counterparty extends credit in connection with the purchase, sale, carrying or trading of securities, but not including other loans that are secured by collateral in the form of securities.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? MarginLoan { get; init; } 
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    public AmountAndDirection53? CashCollateralAmount { get; init; } 
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    public AmountAndDirection53? CollateralMarketValue { get; init; } 
    
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
        if (PrincipalAmount is PrincipalAmount3 PrincipalAmountValue)
        {
            writer.WriteStartElement(null, "PrncplAmt", xmlNamespace );
            PrincipalAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LoanValue is IsoActiveOrHistoricCurrencyAndAmount LoanValueValue)
        {
            writer.WriteStartElement(null, "LnVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(LoanValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (MarketValue is AmountAndDirection53 MarketValueValue)
        {
            writer.WriteStartElement(null, "MktVal", xmlNamespace );
            MarketValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OutstandingMarginLoanAmount is IsoActiveOrHistoricCurrencyAndAmount OutstandingMarginLoanAmountValue)
        {
            writer.WriteStartElement(null, "OutsdngMrgnLnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OutstandingMarginLoanAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ShortMarketValueAmount is IsoActiveOrHistoricCurrencyAndAmount ShortMarketValueAmountValue)
        {
            writer.WriteStartElement(null, "ShrtMktValAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(ShortMarketValueAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (MarginLoan is IsoActiveOrHistoricCurrencyAndAmount MarginLoanValue)
        {
            writer.WriteStartElement(null, "MrgnLn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(MarginLoanValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashCollateralAmount is AmountAndDirection53 CashCollateralAmountValue)
        {
            writer.WriteStartElement(null, "CshCollAmt", xmlNamespace );
            CashCollateralAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralMarketValue is AmountAndDirection53 CollateralMarketValueValue)
        {
            writer.WriteStartElement(null, "CollMktVal", xmlNamespace );
            CollateralMarketValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ExposureMetrics4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
