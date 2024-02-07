﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionReport6.  ISO2002 ID# _dksd0dcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment transactions.
/// </summary>
public partial record TransactionReport6
     : IIsoXmlSerilizable<TransactionReport6>
{
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    public required PaymentIdentification6Choice_ PaymentIdentification { get; init; } 
    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    public required TransactionOrError5Choice_ TransactionOrError { get; init; } 
    
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
        writer.WriteStartElement(null, "PmtId", xmlNamespace );
        PaymentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxOrErr", xmlNamespace );
        TransactionOrError.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TransactionReport6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
