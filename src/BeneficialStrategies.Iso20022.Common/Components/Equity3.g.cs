﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Equity3.  ISO2002 ID# _4YmZIeLZEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument which represents a title of ownership in a company, ie, the shareholder is entitled to a part of the company's profit - usually by payment of a dividend - and to voting rights, if any. Each company issues generally different classes of shares, eg, ordinary or common shares, which have no guaranteed amount of dividend but carry voting rights, or preferred shares, which receive dividends before ordinary shares but have no voting right.
/// </summary>
public partial record Equity3
     : IIsoXmlSerilizable<Equity3>
{
    #nullable enable
    
    /// <summary>
    /// Indicates the level of priority to claim on income and assets of the company in case of the payment of dividends and in the event of a bankruptcy, for example, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// </summary>
    public required PreferenceToIncome5Choice_ PreferenceToIncome { get; init; } 
    /// <summary>
    /// Date/time at which the security will no longer exist, for example, redeemable preference shares.
    /// </summary>
    public IsoISODateTime? MaturityDate { get; init; } 
    /// <summary>
    /// Nominal amount which is not paid yet.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NonPaidAmount { get; init; } 
    /// <summary>
    /// Nominal value of an equity security.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ParValue { get; init; } 
    /// <summary>
    /// Number of voting rights per share.
    /// </summary>
    public IsoNumber? VotingRightsPerShare { get; init; } 
    
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
        writer.WriteStartElement(null, "PrefToIncm", xmlNamespace );
        PreferenceToIncome.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MaturityDate is IsoISODateTime MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(MaturityDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (NonPaidAmount is IsoActiveCurrencyAndAmount NonPaidAmountValue)
        {
            writer.WriteStartElement(null, "NonPdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NonPaidAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ParValue is IsoActiveCurrencyAndAmount ParValueValue)
        {
            writer.WriteStartElement(null, "ParVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ParValueValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (VotingRightsPerShare is IsoNumber VotingRightsPerShareValue)
        {
            writer.WriteStartElement(null, "VtngRghtsPerShr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(VotingRightsPerShareValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
    }
    public static Equity3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
