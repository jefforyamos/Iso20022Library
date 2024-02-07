﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for References7.  ISO2002 ID# _I1XDQeZmEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides a set if identifications to reference to a securities settlement transaction.
/// </summary>
public partial record References7
     : IIsoXmlSerilizable<References7>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner the account servicer and the market infrastructure.
    /// </summary>
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoMax35Text? TradeIdentification { get; init; } 
    
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
        if (AccountOwnerTransactionIdentification is IsoMax35Text AccountOwnerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctOwnrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountOwnerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountServicerTransactionIdentification is IsoMax35Text AccountServicerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MarketInfrastructureTransactionIdentification is IsoMax35Text MarketInfrastructureTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "MktInfrstrctrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MarketInfrastructureTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessorTransactionIdentification is IsoMax35Text ProcessorTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessorTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PoolIdentification is IsoMax35Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PoolIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CommonIdentification is IsoMax35Text CommonIdentificationValue)
        {
            writer.WriteStartElement(null, "CmonId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommonIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TradeIdentification is IsoMax35Text TradeIdentificationValue)
        {
            writer.WriteStartElement(null, "TradId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TradeIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static References7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
