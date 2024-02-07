﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RetrievalFulfilmentInitiation2.  ISO2002 ID# _avsgEYHSEeuwq_rv81SdXw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the fulfilment of a retrieval.
/// </summary>
public partial record RetrievalFulfilmentInitiation2
     : IIsoXmlSerilizable<RetrievalFulfilmentInitiation2>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required Environment21 Environment { get; init; } 
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    public required Context15 Context { get; init; } 
    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    public Transaction136? Transaction { get; init; } 
    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    public OriginalTransaction2? OriginalTransaction { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    public ProtectedData1? ProtectedData { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
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
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cntxt", xmlNamespace );
        Context.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Transaction is Transaction136 TransactionValue)
        {
            writer.WriteStartElement(null, "Tx", xmlNamespace );
            TransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalTransaction is OriginalTransaction2 OriginalTransactionValue)
        {
            writer.WriteStartElement(null, "OrgnlTx", xmlNamespace );
            OriginalTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedData is ProtectedData1 ProtectedDataValue)
        {
            writer.WriteStartElement(null, "PrtctdData", xmlNamespace );
            ProtectedDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RetrievalFulfilmentInitiation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
