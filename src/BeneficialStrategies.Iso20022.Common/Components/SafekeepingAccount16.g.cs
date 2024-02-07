﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafekeepingAccount16.  ISO2002 ID# _yKdFpTT5Ee2j2eQlcOSMKg.
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
public partial record SafekeepingAccount16
     : IIsoXmlSerilizable<SafekeepingAccount16>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account between the account owner and the account servicer.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
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
    public ValueList<HoldingBalance12> InstructedBalance { get; init; } = [];
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    public ValueList<PartyIdentification246Choice_> RightsHolder { get; init; } = [];
    
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
        if (AccountIdentification is IsoMax35Text AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (BlockChainAddressOrWallet is IsoMax140Text BlockChainAddressOrWalletValue)
        {
            writer.WriteStartElement(null, "BlckChainAdrOrWllt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(BlockChainAddressOrWalletValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
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
    }
    public static SafekeepingAccount16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
