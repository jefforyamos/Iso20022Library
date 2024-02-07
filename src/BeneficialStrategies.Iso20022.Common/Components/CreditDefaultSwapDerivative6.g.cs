﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditDefaultSwapDerivative6.  ISO2002 ID# _sLE8ETGaEeiNp7s-9BkwiQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit default swap derivative specific for reporting derivatives on a single name.
/// </summary>
public partial record CreditDefaultSwapDerivative6
     : IIsoXmlSerilizable<CreditDefaultSwapDerivative6>
{
    #nullable enable
    
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying swap.
    /// </summary>
    public IsoISINOct2015Identifier? UnderlyingCreditDefaultSwapIdentification { get; init; } 
    /// <summary>
    /// Identification of the reference obligation for a derivative on a credit default swap.
    /// </summary>
    public required IsoISINOct2015Identifier ObligationIdentification { get; init; } 
    /// <summary>
    /// Describes the single name specific details the derivative is being made on.
    /// </summary>
    public required CreditDefaultSwapSingleName2 SingleName { get; init; } 
    
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
        if (UnderlyingCreditDefaultSwapIdentification is IsoISINOct2015Identifier UnderlyingCreditDefaultSwapIdentificationValue)
        {
            writer.WriteStartElement(null, "UndrlygCdtDfltSwpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISINOct2015Identifier(UnderlyingCreditDefaultSwapIdentificationValue)); // data type ISINOct2015Identifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OblgtnId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISINOct2015Identifier(ObligationIdentification)); // data type ISINOct2015Identifier System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SnglNm", xmlNamespace );
        SingleName.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CreditDefaultSwapDerivative6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
