﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BinaryFile1.  ISO2002 ID# _SuAjOgEcEeCQm6a_G2yO_w_2121992872.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Computer file stored in a binary format.
/// </summary>
[DataContract]
[XmlType]
public partial record BinaryFile1
{
    #nullable enable
    
    /// <summary>
    /// Code specifying the Multipurpose Internet Mail Extensions (MIME) type for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - MIME Media Types (www.iana.org/assignments/media-types).
    /// </summary>
    [DataMember]
    public IsoMax35Text? MIMEType { get; init; } 
    /// <summary>
    /// Specifies the encoding algorithm used for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - Transfer Encodings (www.iana.org/assignments/transfer-encodings).
    /// </summary>
    [DataMember]
    public IsoMax35Text? EncodingType { get; init; } 
    /// <summary>
    /// Specifies a code signifying the particular character set used for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - Character Sets (www.iana.org/assignments/character-sets).
    /// </summary>
    [DataMember]
    public IsoMax35Text? CharacterSet { get; init; } 
    /// <summary>
    /// Binary object included in this attached binary file.
    /// </summary>
    [DataMember]
    public IsoMax100KBinary? IncludedBinaryObject { get; init; } 
    
    #nullable disable
}
