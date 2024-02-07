﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionParties6.  ISO2002 ID# __NrwMW48EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the parties specific to the individual transaction.
/// </summary>
public partial record TransactionParties6
     : IIsoXmlSerilizable<TransactionParties6>
{
    #nullable enable
    
    /// <summary>
    /// Party that initiated the payment that is reported in the entry.
    /// </summary>
    public Party40Choice_? InitiatingParty { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public Party40Choice_? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor.
    /// </summary>
    public CashAccount38? DebtorAccount { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public Party40Choice_? UltimateDebtor { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public Party40Choice_? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry has been posted as a result of the payment transaction.
    /// </summary>
    public CashAccount38? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public Party40Choice_? UltimateCreditor { get; init; } 
    /// <summary>
    /// Party that plays an active role in planning and executing the transactions that create or liquidate investments of the investors assets, or that move the investor's assets from one investment to another. A trading party is a trade instructor, an investment decision-maker, a post trade administrator, or a trader. In the context of treasury, it is the party that negotiates and executes the treasury transaction.
    /// </summary>
    public Party40Choice_? TradingParty { get; init; } 
    /// <summary>
    /// Proprietary party related to the underlying transaction.
    /// </summary>
    public ProprietaryParty5? Proprietary { get; init; } 
    
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
        if (InitiatingParty is Party40Choice_ InitiatingPartyValue)
        {
            writer.WriteStartElement(null, "InitgPty", xmlNamespace );
            InitiatingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Debtor is Party40Choice_ DebtorValue)
        {
            writer.WriteStartElement(null, "Dbtr", xmlNamespace );
            DebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAccount is CashAccount38 DebtorAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAcct", xmlNamespace );
            DebtorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateDebtor is Party40Choice_ UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Creditor is Party40Choice_ CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAccount is CashAccount38 CreditorAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAcct", xmlNamespace );
            CreditorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateCreditor is Party40Choice_ UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradingParty is Party40Choice_ TradingPartyValue)
        {
            writer.WriteStartElement(null, "TradgPty", xmlNamespace );
            TradingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Proprietary is ProprietaryParty5 ProprietaryValue)
        {
            writer.WriteStartElement(null, "Prtry", xmlNamespace );
            ProprietaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionParties6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
