﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountSubLevel14.  ISO2002 ID# _s1xFgVjBEea1XpTdyimpLA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 4).
/// </summary>
public partial record AccountSubLevel14
     : IIsoXmlSerilizable<AccountSubLevel14>
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
    /// Party that manages the sub-level account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public required PartyIdentification100 AccountServicer { get; init; } 
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account (sub-account level 4), for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    public AggregateHoldingBalance3? BalanceDetails { get; init; } 
    /// <summary>
    /// Holdings of level 5.
    /// </summary>
    public AccountSubLevel15? AccountSubLevel5 { get; init; } 
    /// <summary>
    /// Difference in holdings between the sub-account at level 4 and the sub-accounts of level 5.
    /// </summary>
    public AggregateHoldingBalance2? AccountSubLevel5Difference { get; init; } 
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
        if (BalanceDetails is AggregateHoldingBalance3 BalanceDetailsValue)
        {
            writer.WriteStartElement(null, "BalDtls", xmlNamespace );
            BalanceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountSubLevel5 is AccountSubLevel15 AccountSubLevel5Value)
        {
            writer.WriteStartElement(null, "AcctSubLvl5", xmlNamespace );
            AccountSubLevel5Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountSubLevel5Difference is AggregateHoldingBalance2 AccountSubLevel5DifferenceValue)
        {
            writer.WriteStartElement(null, "AcctSubLvl5Diff", xmlNamespace );
            AccountSubLevel5DifferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountSubLevel14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
