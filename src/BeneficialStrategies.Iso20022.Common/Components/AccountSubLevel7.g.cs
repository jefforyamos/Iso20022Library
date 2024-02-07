﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountSubLevel7.  ISO2002 ID# _Lnjfp4j3EeONZKAAW4pOaQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 7).
/// </summary>
public partial record AccountSubLevel7
     : IIsoXmlSerilizable<AccountSubLevel7>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    public required PartyIdentification100 AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the sub-account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public required PartyIdentification100 AccountServicer { get; init; } 
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    public AggregateHoldingBalance1? BalanceForAccount { get; init; } 
    /// <summary>
    /// Holdings of level 8.
    /// </summary>
    public AccountSubLevel8? AccountSubLevel8 { get; init; } 
    /// <summary>
    /// Difference in holdings between the sub-account at level 7 and the sub-accounts of level 8.
    /// </summary>
    public AggregateHoldingBalance2? AccountSubLevel8Difference { get; init; } 
    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    public Intermediary29? Agent { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        writer.WriteStartElement(null, "AcctId", xmlNamespace );
        AccountIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
        AccountOwner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
        AccountServicer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BeneficialOwner is BeneficialOwner2 BeneficialOwnerValue)
        {
            writer.WriteStartElement(null, "BnfclOwnr", xmlNamespace );
            BeneficialOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceForAccount is AggregateHoldingBalance1 BalanceForAccountValue)
        {
            writer.WriteStartElement(null, "BalForAcct", xmlNamespace );
            BalanceForAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountSubLevel8 is AccountSubLevel8 AccountSubLevel8Value)
        {
            writer.WriteStartElement(null, "AcctSubLvl8", xmlNamespace );
            AccountSubLevel8Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountSubLevel8Difference is AggregateHoldingBalance2 AccountSubLevel8DifferenceValue)
        {
            writer.WriteStartElement(null, "AcctSubLvl8Diff", xmlNamespace );
            AccountSubLevel8DifferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Agent is Intermediary29 AgentValue)
        {
            writer.WriteStartElement(null, "Agt", xmlNamespace );
            AgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountSubLevel7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
