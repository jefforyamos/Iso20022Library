﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Context6.  ISO2002 ID# _O6b2QeE6EeeV6-yubHrZaQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
public partial record Context6
     : IIsoXmlSerilizable<Context6>
{
    #nullable enable
    
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    public TransactionContext6? TransactionContext { get; init; } 
    
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
        if (TransactionContext is TransactionContext6 TransactionContextValue)
        {
            writer.WriteStartElement(null, "TxCntxt", xmlNamespace );
            TransactionContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Context6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
