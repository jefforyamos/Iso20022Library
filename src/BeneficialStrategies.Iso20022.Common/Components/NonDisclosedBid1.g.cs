﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonDisclosedBid1.  ISO2002 ID# _S0yZ2tp-Ed-ak6NoX_4Aeg_1294975941.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List trading by which the buy-side provides details to the sell-side information about the sector, country, index and potential market impact of the financial instrument to be bought or sold. Using this information, the sell-side firms bid for the trade.
/// </summary>
public partial record NonDisclosedBid1
     : IIsoXmlSerilizable<NonDisclosedBid1>
{
    #nullable enable
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the currency) of all securities of a list.
    /// </summary>
    public CountryCode? BidByCurrency { get; init; } 
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the sector) of all securities of a list.
    /// </summary>
    public IsoMax128Text? BidBySector { get; init; } 
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the index) of all securities of a list.
    /// </summary>
    public IsoMax128Text? BidByIndex { get; init; } 
    /// <summary>
    /// Indicates the side of the bid in the case of a non disclosed bidding process. Used instead of buy and sell side.|True = Side 1|False = Side 2.
    /// </summary>
    public IsoTrueFalseIndicator? SideIndicator { get; init; } 
    /// <summary>
    /// Provides additionnal details about the liquidity of a financial instrument.
    /// </summary>
    public Liquidity1? Liquidity { get; init; } 
    /// <summary>
    /// Details about the exchange for physical trade parameters.
    /// </summary>
    public ExchangeForPhysicalTradeParameters1? ExchangeForPhysicalTrade { get; init; } 
    
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
        if (BidByCurrency is CountryCode BidByCurrencyValue)
        {
            writer.WriteStartElement(null, "BidByCcy", xmlNamespace );
            writer.WriteValue(BidByCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BidBySector is IsoMax128Text BidBySectorValue)
        {
            writer.WriteStartElement(null, "BidBySctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax128Text(BidBySectorValue)); // data type Max128Text System.String
            writer.WriteEndElement();
        }
        if (BidByIndex is IsoMax128Text BidByIndexValue)
        {
            writer.WriteStartElement(null, "BidByIndx", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax128Text(BidByIndexValue)); // data type Max128Text System.String
            writer.WriteEndElement();
        }
        if (SideIndicator is IsoTrueFalseIndicator SideIndicatorValue)
        {
            writer.WriteStartElement(null, "SdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(SideIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (Liquidity is Liquidity1 LiquidityValue)
        {
            writer.WriteStartElement(null, "Lqdty", xmlNamespace );
            LiquidityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExchangeForPhysicalTrade is ExchangeForPhysicalTradeParameters1 ExchangeForPhysicalTradeValue)
        {
            writer.WriteStartElement(null, "XchgForPhysTrad", xmlNamespace );
            ExchangeForPhysicalTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static NonDisclosedBid1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
