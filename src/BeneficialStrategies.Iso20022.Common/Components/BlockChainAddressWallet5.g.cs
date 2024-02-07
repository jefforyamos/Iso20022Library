﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BlockChainAddressWallet5.  ISO2002 ID# _9KVakSqPEeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital account where digital assets or digital tokens can be stored and where an entry is made.
/// </summary>
public partial record BlockChainAddressWallet5
     : IIsoXmlSerilizable<BlockChainAddressWallet5>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the collateral account.
    /// </summary>
    public required IsoMax140Text Identification { get; init; } 
    /// <summary>
    /// Indicates the type of collateral account.
    /// </summary>
    public CollateralAccountIdentificationType3Choice_? Type { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax140Text(Identification)); // data type Max140Text System.String
        writer.WriteEndElement();
        if (Type is CollateralAccountIdentificationType3Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static BlockChainAddressWallet5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
