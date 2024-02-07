﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount203.  ISO2002 ID# _hgTI8Ss-EeySlt9bF77XfA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties involved in the triparty collateral transaction.
/// </summary>
public partial record PartyIdentificationAndAccount203
     : IIsoXmlSerilizable<PartyIdentificationAndAccount203>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification120Choice_ Identification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account of the party.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Specifies the role of the party in the transaction.
    /// </summary>
    public TradingPartyCapacity5Choice_? PartyCapacity { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (AlternateIdentification is AlternatePartyIdentification7 AlternateIdentificationValue)
        {
            writer.WriteStartElement(null, "AltrnId", xmlNamespace );
            AlternateIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount19 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockChainAddressOrWallet is BlockChainAddressWallet3 BlockChainAddressOrWalletValue)
        {
            writer.WriteStartElement(null, "BlckChainAdrOrWllt", xmlNamespace );
            BlockChainAddressOrWalletValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PartyCapacity is TradingPartyCapacity5Choice_ PartyCapacityValue)
        {
            writer.WriteStartElement(null, "PtyCpcty", xmlNamespace );
            PartyCapacityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentificationAndAccount203 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
