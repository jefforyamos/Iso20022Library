﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SyndicatedLoan2.  ISO2002 ID# _JtldpW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loan offered by a group of lenders (called a syndicate) who work together to lend an amount of money to a single borrower.
/// </summary>
public partial record SyndicatedLoan2
     : IIsoXmlSerilizable<SyndicatedLoan2>
{
    #nullable enable
    
    /// <summary>
    /// Party which obtains the loan.
    /// </summary>
    public required TradeParty5 Borrower { get; init; } 
    /// <summary>
    /// Party which provides an amount of money available to others to borrow.
    /// </summary>
    public TradeParty5? Lender { get; init; } 
    /// <summary>
    /// Amount of the part in the syndicated loan.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Share of the part in the syndicated loan.
    /// </summary>
    public IsoPercentageRate? Share { get; init; } 
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Brrwr", xmlNamespace );
        Borrower.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Lender is TradeParty5 LenderValue)
        {
            writer.WriteStartElement(null, "Lndr", xmlNamespace );
            LenderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Amount is IsoActiveCurrencyAndAmount AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Share is IsoPercentageRate ShareValue)
        {
            writer.WriteStartElement(null, "Shr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(ShareValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (ExchangeRateInformation is ExchangeRate1 ExchangeRateInformationValue)
        {
            writer.WriteStartElement(null, "XchgRateInf", xmlNamespace );
            ExchangeRateInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SyndicatedLoan2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
