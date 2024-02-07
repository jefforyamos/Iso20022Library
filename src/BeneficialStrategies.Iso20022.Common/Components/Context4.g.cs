﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Context4.  ISO2002 ID# _IRz0cVZpEeeFltjJxERUxw.
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
public partial record Context4
     : IIsoXmlSerilizable<Context4>
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    public PointOfServiceContext2? PointOfServiceContext { get; init; } 
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    public required TransactionContext3 TransactionContext { get; init; } 
    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    public SaleContext7? SaleContext { get; init; } 
    
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
        if (PointOfServiceContext is PointOfServiceContext2 PointOfServiceContextValue)
        {
            writer.WriteStartElement(null, "PtOfSvcCntxt", xmlNamespace );
            PointOfServiceContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxCntxt", xmlNamespace );
        TransactionContext.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SaleContext is SaleContext7 SaleContextValue)
        {
            writer.WriteStartElement(null, "SaleCntxt", xmlNamespace );
            SaleContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Context4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
