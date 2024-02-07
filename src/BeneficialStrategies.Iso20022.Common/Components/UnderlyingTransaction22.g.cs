﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTransaction22.  ISO2002 ID# __qvfl248EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying (group of) transaction(s) to which the resolution of investigation applies.
/// </summary>
public partial record UnderlyingTransaction22
     : IIsoXmlSerilizable<UnderlyingTransaction22>
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original cancellation message, to which the resolution refers.
    /// </summary>
    public OriginalGroupHeader14? OriginalGroupInformationAndStatus { get; init; } 
    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation status refers.
    /// </summary>
    public OriginalPaymentInstruction30? OriginalPaymentInformationAndStatus { get; init; } 
    /// <summary>
    /// Provides details on the original transactions to which the cancellation request message refers.
    /// </summary>
    public PaymentTransaction102? TransactionInformationAndStatus { get; init; } 
    
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
        if (OriginalGroupInformationAndStatus is OriginalGroupHeader14 OriginalGroupInformationAndStatusValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInfAndSts", xmlNamespace );
            OriginalGroupInformationAndStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalPaymentInformationAndStatus is OriginalPaymentInstruction30 OriginalPaymentInformationAndStatusValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtInfAndSts", xmlNamespace );
            OriginalPaymentInformationAndStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionInformationAndStatus is PaymentTransaction102 TransactionInformationAndStatusValue)
        {
            writer.WriteStartElement(null, "TxInfAndSts", xmlNamespace );
            TransactionInformationAndStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static UnderlyingTransaction22 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
