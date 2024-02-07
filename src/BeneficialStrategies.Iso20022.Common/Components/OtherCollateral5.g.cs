﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherCollateral5.  ISO2002 ID# _wXjxtYFvEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the letter of credit or bank guarantee, or other collateral, posted as collateral.
/// </summary>
public partial record OtherCollateral5
     : IIsoXmlSerilizable<OtherCollateral5>
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Provides the unique identification of the letter of credit.
    /// </summary>
    public IsoMax35Text? LetterOfCreditIdentification { get; init; } 
    /// <summary>
    /// Amount of the letter/documentary credit.
    /// </summary>
    public IsoActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; } 
    /// <summary>
    /// Amount of the bank guarantee.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GuaranteeAmount { get; init; } 
    /// <summary>
    /// Provides a description and an amount of another type of collateral.
    /// </summary>
    public OtherTypeOfCollateral2? OtherTypeOfCollateral { get; init; } 
    /// <summary>
    /// Date on which the other collateral was issued.
    /// </summary>
    public DateFormat14Choice_? IssueDate { get; init; } 
    /// <summary>
    /// Date on which the other collateral expires.
    /// </summary>
    public DateFormat14Choice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Indicates that the collateral deposited in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    /// <summary>
    /// Party that issues the bank guarantee or letter of / documentary credit.
    /// </summary>
    public PartyIdentification100Choice_? Issuer { get; init; } 
    /// <summary>
    /// Valuation date of the other collateral when it was taken as collateral.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Exchange rate.
    /// </summary>
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    public IsoActiveCurrencyAndAmount? MarketValue { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    public IsoPercentageRate? Haircut { get; init; } 
    /// <summary>
    /// Value of the collateral after taking into account the haircut, if any.
    /// </summary>
    public required IsoActiveCurrencyAndAmount CollateralValue { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
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
        if (LetterOfCreditIdentification is IsoMax35Text LetterOfCreditIdentificationValue)
        {
            writer.WriteStartElement(null, "LttrOfCdtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LetterOfCreditIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (LetterOfCreditAmount is IsoActiveCurrencyAndAmount LetterOfCreditAmountValue)
        {
            writer.WriteStartElement(null, "LttrOfCdtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(LetterOfCreditAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (GuaranteeAmount is IsoActiveCurrencyAndAmount GuaranteeAmountValue)
        {
            writer.WriteStartElement(null, "GrntAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(GuaranteeAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OtherTypeOfCollateral is OtherTypeOfCollateral2 OtherTypeOfCollateralValue)
        {
            writer.WriteStartElement(null, "OthrTpOfColl", xmlNamespace );
            OtherTypeOfCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssueDate is DateFormat14Choice_ IssueDateValue)
        {
            writer.WriteStartElement(null, "IsseDt", xmlNamespace );
            IssueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpiryDate is DateFormat14Choice_ ExpiryDateValue)
        {
            writer.WriteStartElement(null, "XpryDt", xmlNamespace );
            ExpiryDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LimitedCoverageIndicator is IsoYesNoIndicator LimitedCoverageIndicatorValue)
        {
            writer.WriteStartElement(null, "LtdCvrgInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(LimitedCoverageIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Issuer is PartyIdentification100Choice_ IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            IssuerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueDate is IsoISODate ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ExchangeRate is IsoBaseOneRate ExchangeRateValue)
        {
            writer.WriteStartElement(null, "XchgRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRateValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (MarketValue is IsoActiveCurrencyAndAmount MarketValueValue)
        {
            writer.WriteStartElement(null, "MktVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(MarketValueValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Haircut is IsoPercentageRate HaircutValue)
        {
            writer.WriteStartElement(null, "Hrcut", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(HaircutValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CollVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CollateralValue)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (SafekeepingPlace is SafekeepingPlaceFormat10Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount19 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OtherCollateral5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
