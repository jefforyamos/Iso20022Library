﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafekeepingAccount14.  ISO2002 ID# _gCI9BxuUEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification and information about a securities account and balance.
/// </summary>
public partial record SafekeepingAccount14
     : IIsoXmlSerilizable<SafekeepingAccount14>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public ValueList<HoldingBalance10> InstructedBalance { get; init; } = [];
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    public ValueList<PartyIdentification237Choice_> RightsHolder { get; init; } = [];
    /// <summary>
    /// Detailed information about the pledge.
    /// </summary>
    public PledgeInformation1? PledgeDetails { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (AccountOwner is PartyIdentification231Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubAccountIdentification is IsoMax35Text SubAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "SubAcctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SubAccountIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InstdBal", xmlNamespace );
        InstructedBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RghtsHldr", xmlNamespace );
        RightsHolder.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PledgeDetails is PledgeInformation1 PledgeDetailsValue)
        {
            writer.WriteStartElement(null, "PldgDtls", xmlNamespace );
            PledgeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SafekeepingAccount14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
