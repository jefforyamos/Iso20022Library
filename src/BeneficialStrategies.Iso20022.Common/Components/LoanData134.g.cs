﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanData134.  ISO2002 ID# _F8Sz8cguEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a securities lending transaction.
/// </summary>
public partial record LoanData134
     : IIsoXmlSerilizable<LoanData134>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the type of the transaction.
    /// </summary>
    public ExposureType10Code? ContractType { get; init; } 
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    public IsoTrueFalseIndicator? Cleared { get; init; } 
    /// <summary>
    /// Unique code determined by the reporting counterparty identifying the portfolio.
    /// </summary>
    public IsoMax52Text? PortfolioCode { get; init; } 
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    public TradingVenueType1Choice_? TradingVenue { get; init; } 
    /// <summary>
    /// Type of agreement expressed as a code set. Reference to the master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    public ExternalAgreementType1Code? MasterAgreementType { get; init; } 
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction. This information shall not be reported for open term agreements.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
    /// </summary>
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
    /// </summary>
    public ContractTerm6Choice_? Term { get; init; } 
    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    public Rates1Choice_? Rates { get; init; } 
    /// <summary>
    /// Medium of exchange of currency.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? PrincipalAmountCurrency { get; init; } 
    /// <summary>
    /// Currency in which the the security or commodity price is denominated.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? PriceCurrency { get; init; } 
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    public Security49? Security { get; init; } 
    /// <summary>
    /// Margin loans in base currency.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? OutstandingMarginLoanCurrency { get; init; } 
    
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
        if (ContractType is ExposureType10Code ContractTypeValue)
        {
            writer.WriteStartElement(null, "CtrctTp", xmlNamespace );
            writer.WriteValue(ContractTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Cleared is IsoTrueFalseIndicator ClearedValue)
        {
            writer.WriteStartElement(null, "Clrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ClearedValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (PortfolioCode is IsoMax52Text PortfolioCodeValue)
        {
            writer.WriteStartElement(null, "PrtflCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax52Text(PortfolioCodeValue)); // data type Max52Text System.String
            writer.WriteEndElement();
        }
        if (TradingVenue is TradingVenueType1Choice_ TradingVenueValue)
        {
            writer.WriteStartElement(null, "TradgVn", xmlNamespace );
            TradingVenueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MasterAgreementType is ExternalAgreementType1Code MasterAgreementTypeValue)
        {
            writer.WriteStartElement(null, "MstrAgrmtTp", xmlNamespace );
            writer.WriteValue(MasterAgreementTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (MaturityDate is IsoISODate MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (GeneralCollateral is SpecialCollateral1Code GeneralCollateralValue)
        {
            writer.WriteStartElement(null, "GnlColl", xmlNamespace );
            writer.WriteValue(GeneralCollateralValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Term is ContractTerm6Choice_ TermValue)
        {
            writer.WriteStartElement(null, "Term", xmlNamespace );
            TermValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Rates is Rates1Choice_ RatesValue)
        {
            writer.WriteStartElement(null, "Rates", xmlNamespace );
            RatesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrincipalAmountCurrency is ActiveOrHistoricCurrencyCode PrincipalAmountCurrencyValue)
        {
            writer.WriteStartElement(null, "PrncplAmtCcy", xmlNamespace );
            writer.WriteValue(PrincipalAmountCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PriceCurrency is ActiveOrHistoricCurrencyCode PriceCurrencyValue)
        {
            writer.WriteStartElement(null, "PricCcy", xmlNamespace );
            writer.WriteValue(PriceCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Security is Security49 SecurityValue)
        {
            writer.WriteStartElement(null, "Scty", xmlNamespace );
            SecurityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OutstandingMarginLoanCurrency is ActiveOrHistoricCurrencyCode OutstandingMarginLoanCurrencyValue)
        {
            writer.WriteStartElement(null, "OutsdngMrgnLnCcy", xmlNamespace );
            writer.WriteValue(OutstandingMarginLoanCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static LoanData134 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
