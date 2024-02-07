﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerFinancialInitiation1.  ISO2002 ID# _oCk1QHubEeSBS-QFUaKA-g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to financial authorisation.
/// </summary>
public partial record AcquirerFinancialInitiation1
     : IIsoXmlSerilizable<AcquirerFinancialInitiation1>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardTransactionEnvironment1 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    public required CardTransactionContext1 Context { get; init; } 
    /// <summary>
    /// Card transaction for which the financial authorisation has been requested.
    /// </summary>
    public required CardTransaction5 Transaction { get; init; } 
    
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
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cntxt", xmlNamespace );
        Context.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AcquirerFinancialInitiation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
