﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TimeOutResult2.  ISO2002 ID# _RbFb8tp-Ed-ak6NoX_4Aeg_-1237479550.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the time-out consequences.
/// </summary>
public partial record TimeOutResult2
     : IIsoXmlSerilizable<TimeOutResult2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the transaction if no action is taken by the user.
    /// </summary>
    public required TransactionStatus5 TransactionFutureStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "TxFutrSts", xmlNamespace );
        TransactionFutureStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TimeOutResult2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
