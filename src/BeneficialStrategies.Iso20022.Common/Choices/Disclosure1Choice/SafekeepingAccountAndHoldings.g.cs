﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SafekeepingAccountAndHoldings.  ISO2002 ID# _WtmescANEembi_x1QDJfxw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Disclosure1Choice;

/// <summary>
/// Details of the account, account sub-levels and holdings.
/// </summary>
public partial record SafekeepingAccountAndHoldings : Disclosure1Choice_
     , IIsoXmlSerilizable<SafekeepingAccountAndHoldings>
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained. Account held by the responding intermediary with its account servicer.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public required PartyIdentification195Choice_ AccountServicer { get; init; } 
    /// <summary>
    /// Number of shares held by the responding intermediary on its own account.
    /// </summary>
    public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; init; } 
    /// <summary>
    /// Number of shares held by the responding intermediary on account of someone else.
    /// </summary>
    public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; init; } 
    /// <summary>
    /// Total number of shares held by the responding intermediary.
    /// </summary>
    public required FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; init; } 
    /// <summary>
    /// Shareholdings information at account sub level.
    /// </summary>
    public AccountSublevel21? AccountSubLevel { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(SafekeepingAccount)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
        AccountServicer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ShrhldgBalOnOwnAcct", xmlNamespace );
        ShareholdingBalanceOnOwnAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ShrhldgBalOnClntAcct", xmlNamespace );
        ShareholdingBalanceOnClientAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlShrhldgBal", xmlNamespace );
        TotalShareholdingBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountSubLevel is AccountSublevel21 AccountSubLevelValue)
        {
            writer.WriteStartElement(null, "AcctSubLvl", xmlNamespace );
            AccountSubLevelValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new SafekeepingAccountAndHoldings Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
