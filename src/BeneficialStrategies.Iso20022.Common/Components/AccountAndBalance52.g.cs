﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountAndBalance52.  ISO2002 ID# _plLZnzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account and balance information.
/// </summary>
public partial record AccountAndBalance52
     : IIsoXmlSerilizable<AccountAndBalance52>
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public IsoRestrictedFINXMax140Text? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification136Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public required CorporateActionBalanceDetails45 Balance { get; init; } 
    
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
        if (SafekeepingAccount is IsoRestrictedFINXMax35Text SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax35Text(SafekeepingAccountValue)); // data type RestrictedFINXMax35Text System.String
            writer.WriteEndElement();
        }
        if (BlockChainAddressOrWallet is IsoRestrictedFINXMax140Text BlockChainAddressOrWalletValue)
        {
            writer.WriteStartElement(null, "BlckChainAdrOrWllt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax140Text(BlockChainAddressOrWalletValue)); // data type RestrictedFINXMax140Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification136Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormat32Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Bal", xmlNamespace );
        Balance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AccountAndBalance52 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
