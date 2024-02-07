﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PairedOffQuantity.  ISO2002 ID# _UdsRVNp-Ed-ak6NoX_4Aeg_1449164815.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity1Choice;

/// <summary>
/// Quantity of financial instruments of the linked transaction to be paired-off.
/// </summary>
public partial record PairedOffQuantity : PairedOrTurnedQuantity1Choice_
     , IIsoXmlSerilizable<PairedOffQuantity>
{
    #nullable enable
    
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
    }
    public static new PairedOffQuantity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
