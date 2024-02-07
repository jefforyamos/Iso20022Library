﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BorrowerLendingDeadline1.  ISO2002 ID# _tqJCIGLDEeWR9ZSfjmHwUA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stock lending deadline assigned to a borrower of the stock.
/// </summary>
public partial record BorrowerLendingDeadline1
     : IIsoXmlSerilizable<BorrowerLendingDeadline1>
{
    #nullable enable
    
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    public required DateFormat31Choice_ StockLendingDeadline { get; init; } 
    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    public required PartyIdentification92Choice_ Borrower { get; init; } 
    
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
        writer.WriteStartElement(null, "StockLndgDdln", xmlNamespace );
        StockLendingDeadline.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Brrwr", xmlNamespace );
        Borrower.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static BorrowerLendingDeadline1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
