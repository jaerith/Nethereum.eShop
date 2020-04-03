using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum.Commerce.Contracts.SellerAdmin.ContractDefinition
{


    public partial class SellerAdminDeployment : SellerAdminDeploymentBase
    {
        public SellerAdminDeployment() : base(BYTECODE) { }
        public SellerAdminDeployment(string byteCode) : base(byteCode) { }
    }

    public class SellerAdminDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040523480156200001157600080fd5b5060405162001f3138038062001f318339810160408190526200003491620000d3565b600080546001600160a01b03191633178082556040516001600160a01b039190911691907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0908290a3600380546001600160a01b0319166001600160a01b038416179055620000a381620000af565b60055550620001e39050565b80516000908290620000c6575060009050620000ce565b505060208101515b919050565b60008060408385031215620000e6578182fd5b82516001600160a01b0381168114620000fd578283fd5b60208401519092506001600160401b03808211156200011a578283fd5b81850186601f8201126200012c578384fd5b80519250818311156200013d578384fd5b62000152601f8401601f191660200162000189565b915082825286602084830101111562000169578384fd5b6200017c836020840160208401620001b0565b5080925050509250929050565b6040518181016001600160401b0381118282101715620001a857600080fd5b604052919050565b60005b83811015620001cd578181015183820152602001620001b3565b83811115620001dd576000848401525b50505050565b611d3e80620001f36000396000f3fe608060405234801561001057600080fd5b50600436106101425760003560e01c80638f32d59b116100b8578063cfb519281161007c578063cfb519281461027f578063d48dde9114610292578063dc2d10de146102a5578063e0723c93146102c5578063f2fde38b146102d8578063f3ad65f4146102eb57610142565b80638f32d59b14610241578063abefab8714610249578063b4bf807f14610251578063c76ea97814610259578063ce51d8ec1461026c57610142565b80636b00e9d81161010a5780636b00e9d8146101b357806370507055146101d357806385057a09146101e65780638847aa1f146101f95780638da5cb5b1461020c5780638e5fc30b1461022157610142565b8063150e99f9146101475780631a407b7b1461015c578063261d75551461016f578063288134711461018d5780634a9ccc41146101a0575b600080fd5b61015a6101553660046112eb565b6102f3565b005b61015a61016a3660046113d5565b6103ce565b6101776104b8565b6040516101849190611968565b60405180910390f35b61015a61019b3660046115f4565b6104be565b61015a6101ae3660046113d5565b610555565b6101c66101c13660046112eb565b610604565b604051610184919061195d565b61015a6101e13660046113d5565b610619565b61015a6101f436600461134b565b6106c7565b61015a6102073660046113d5565b6107ac565b61021461085b565b6040516101849190611949565b61023461022f36600461132a565b61086a565b60405161018491906119a0565b6101c6610994565b6101776109a5565b6102146109ab565b61015a6102673660046112eb565b6109ba565b61015a61027a3660046113d5565b610a8f565b61017761028d3660046114a1565b610b3e565b61015a6102a0366004611432565b610b60565b6102b86102b336600461138b565b610c50565b6040516101849190611b42565b6102b86102d336600461138b565b610d40565b61015a6102e63660046112eb565b610dd1565b610214610dfe565b6102fb610994565b6103205760405162461bcd60e51b815260040161031790611ad8565b60405180910390fd5b6001600160a01b03811660009081526001602052604090205460ff1615610396576001600160a01b038116600081815260016020526040808220805460ff1916905560028054600019019055517f8ddb5a2efd673581f97000ec107674428dc1ed37e8e7944654e48fb0688114779190a26103cb565b6040516001600160a01b038216907f21aa6b3368eceb61c9fc1bdfd2cb6337c87cc1510c1afcc7d5a45371551b43b890600090a25b50565b6103d6610994565b6103f25760405162461bcd60e51b815260040161031790611ad8565b600061043385858080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b905061043d610f4f565b61044682610e0d565b6040808201519051631af3138f60e21b8152919250906001600160a01b03821690636bcc4e3c9061047d9088908890600401611c6e565b600060405180830381600087803b15801561049757600080fd5b505af11580156104ab573d6000803e3d6000fd5b5050505050505050505050565b60055481565b6104c6610f4f565b6104d38260800135610e0d565b60408101519091506001600160a01b031633146105025760405162461bcd60e51b8152600401610317906119f3565b61051260808301606084016112eb565b6001600160a01b03168260a0013583608001357f33e12327aad3aa4dee98e92ffded7cb80463ba5af392befab629aec83cc3343760405160405180910390a45050565b61055d610994565b6105795760405162461bcd60e51b815260040161031790611ad8565b60006105ba85858080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b90506105c4610f4f565b6105cd82610e0d565b6040808201519051634ac5042f60e01b8152919250906001600160a01b03821690634ac5042f9061047d9088908890600401611c6e565b60016020526000908152604090205460ff1681565b610621610994565b61063d5760405162461bcd60e51b815260040161031790611ad8565b600061067e85858080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b9050610688610f4f565b61069182610e0d565b60408082015190516266c41560e91b8152919250906001600160a01b0382169063cd882a009061047d9088908890600401611c6e565b6106cf610994565b6106eb5760405162461bcd60e51b815260040161031790611ad8565b60035460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c1539061071d9085908590600401611971565b60206040518083038186803b15801561073557600080fd5b505afa158015610749573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525061076d919081019061130e565b600480546001600160a01b0319166001600160a01b039283161790819055166107a85760405162461bcd60e51b815260040161031790611a6e565b5050565b6107b4610994565b6107d05760405162461bcd60e51b815260040161031790611ad8565b600061081185858080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b905061081b610f4f565b61082482610e0d565b60408082015190516346885b5b60e01b8152919250906001600160a01b038216906346885b5b9061047d9088908890600401611c6e565b6000546001600160a01b031690565b6040805160208082528183019092526060918291906020820181803883390190505090506000805b60208110156108e8576008810260020a86026001600160f81b03198116156108df57808484815181106108c157fe5b60200101906001600160f81b031916908160001a9053506001909201915b50600101610892565b506000818511806108f7575084155b1561090357508061090a565b5060001984015b6060816040519080825280601f01601f191660200182016040528015610937576020820181803883390190505b50905060005b828110156109875784818151811061095157fe5b602001015160f81c60f81b82828151811061096857fe5b60200101906001600160f81b031916908160001a90535060010161093d565b5093505050505b92915050565b6000546001600160a01b0316331490565b60025481565b6004546001600160a01b031681565b6109c2610994565b6109de5760405162461bcd60e51b815260040161031790611ad8565b6001600160a01b03811660009081526001602052604090205460ff1615610a38576040516001600160a01b038216907ff6831fd5f976003f3acfcf6b2784b2f81e3abb43d161884873a310d6beadf38090600090a26103cb565b6001600160a01b0381166000818152600160208190526040808320805460ff19168317905560028054909201909155517f3c4dcdfdb789d0f39b8a520a4f83ab2599db1d2ececebe4db2385f360c0d3ce19190a250565b610a97610994565b610ab35760405162461bcd60e51b815260040161031790611ad8565b6000610af485858080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b9050610afe610f4f565b610b0782610e0d565b6040808201519051631ed7e53760e11b8152919250906001600160a01b03821690633dafca6e9061047d9088908890600401611c6e565b80516000908290610b53575060009050610b5b565b505060208101515b919050565b610b68610994565b610b845760405162461bcd60e51b815260040161031790611ad8565b6000610bc587878080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b9050610bcf610f4f565b610bd882610e0d565b6040808201519051636cc2c11160e01b8152919250906001600160a01b03821690636cc2c11190610c13908a908a908a908a90600401611c7f565b600060405180830381600087803b158015610c2d57600080fd5b505af1158015610c41573d6000803e3d6000fd5b50505050505050505050505050565b610c58610f8d565b6000610c9985858080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b9050610ca3610f4f565b610cac82610e0d565b604080820151905163191a607f60e31b8152919250906001600160a01b0382169063c8d303f890610ce1908890600401611968565b60006040518083038186803b158015610cf957600080fd5b505afa158015610d0d573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610d359190810190611636565b979650505050505050565b610d48610f8d565b6000610d8985858080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250610b3e92505050565b9050610d93610f4f565b610d9c82610e0d565b60408082015190516317eb9fcb60e11b8152919250906001600160a01b03821690632fd73f9690610ce1908890600401611968565b610dd9610994565b610df55760405162461bcd60e51b815260040161031790611ad8565b6103cb81610ef4565b6003546001600160a01b031681565b610e15610f4f565b610e1d610f4f565b60048054604051632cf9174960e21b81526001600160a01b039091169163b3e45d2491610e4c91879101611968565b60006040518083038186803b158015610e6457600080fd5b505afa158015610e78573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610ea0919081019061152b565b60408101519091506001600160a01b0316610ecd5760405162461bcd60e51b815260040161031790611a37565b60008160a0015160ff161161098e5760405162461bcd60e51b815260040161031790611b0d565b600080546040516001600160a01b03808516939216917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e091a3600080546001600160a01b0319166001600160a01b0392909216919091179055565b6040805160e08101825260008082526020820181905291810182905260608082018390526080820183905260a082019290925260c081019190915290565b6040805161022081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c0810182905260e0810182905261010081018290526101208101829052610140810182905290610160820190815260200160008152602001600060ff16815260200160608152602001600060ff168152602001606081525090565b805161098e81611ce4565b600082601f830112611036578081fd5b815161104961104482611cc4565b611c9d565b81815291506020808301908481018184028601820187101561106a57600080fd5b60005b8481101561109257815161108081611ce4565b8452928201929082019060010161106d565b505050505092915050565b600082601f8301126110ad578081fd5b81516110bb61104482611cc4565b8181529150602080830190848101818402860182018710156110dc57600080fd5b60005b84811015611092578151845292820192908201906001016110df565b600082601f83011261110b578081fd5b815161111961104482611cc4565b81815291506020808301908481016102408085028701830188101561113d57600080fd5b60005b858110156112505781838a03121561115757600080fd5b61116082611c9d565b835181526111708a8686016112e0565b8582015260408401516040820152606084015160608201526080840151608082015260a084015160a082015260c084015160c082015260e084015160e08201526101006111bf8b82870161101b565b90820152610120848101519082015261014080850151908201526101606111e88b82870161127b565b9082015261018084810151908201526101a080850151908201526101c080850151908201526101e080850151908201526102006112278b82870161125c565b9082015261022061123a8b86830161126c565b9082015285529383019391810191600101611140565b50505050505092915050565b8051801515811461098e57600080fd5b80516004811061098e57600080fd5b80516009811061098e57600080fd5b80516003811061098e57600080fd5b60008083601f8401126112aa578182fd5b50813567ffffffffffffffff8111156112c1578182fd5b6020830191508360208285010111156112d957600080fd5b9250929050565b805161098e81611cf9565b6000602082840312156112fc578081fd5b813561130781611ce4565b9392505050565b60006020828403121561131f578081fd5b815161130781611ce4565b6000806040838503121561133c578081fd5b50508035926020909101359150565b6000806020838503121561135d578182fd5b823567ffffffffffffffff811115611373578283fd5b61137f85828601611299565b90969095509350505050565b60008060006040848603121561139f578081fd5b833567ffffffffffffffff8111156113b5578182fd5b6113c186828701611299565b909790965060209590950135949350505050565b600080600080606085870312156113ea578182fd5b843567ffffffffffffffff811115611400578283fd5b61140c87828801611299565b90955093505060208501359150604085013561142781611cf9565b939692955090935050565b60008060008060008060a0878903121561144a578384fd5b863567ffffffffffffffff811115611460578485fd5b61146c89828a01611299565b90975095505060208701359350604087013561148781611cf9565b959894975092956060810135946080909101359350915050565b600060208083850312156114b3578182fd5b823567ffffffffffffffff808211156114ca578384fd5b81850186601f8201126114db578485fd5b80359250818311156114eb578485fd5b6114fd601f8401601f19168501611c9d565b91508282528684848301011115611512578485fd5b8284820185840137509081019091019190915292915050565b60006020828403121561153c578081fd5b815167ffffffffffffffff80821115611553578283fd5b81840160e08187031215611565578384fd5b61156f60e0611c9d565b9250805183526020810151602084015261158c866040830161101b565b604084015261159e866060830161125c565b60608401526115b0866080830161101b565b60808401526115c28660a083016112e0565b60a084015260c0810151828111156115d8578485fd5b6115e487828401611026565b60c0850152509195945050505050565b600060208284031215611605578081fd5b813567ffffffffffffffff81111561161b578182fd5b808301610220818603121561162e578283fd5b949350505050565b600060208284031215611647578081fd5b815167ffffffffffffffff8082111561165e578283fd5b610220918401808603831315611672578384fd5b61167b83611c9d565b8151815261168c876020840161101b565b602082015261169e876040840161101b565b60408201526116b0876060840161101b565b60608201526080820151608082015260a082015160a082015260c082015160c08201526116e08760e0840161101b565b60e082015261010082810151908201526101208083015190820152610140935061170c8785840161101b565b8482015261016093506117218785840161128a565b84820152610180935083820151848201526101a09350611743878584016112e0565b848201526101c09350838201518381111561175c578586fd5b611768888285016110fb565b85830152506101e0935061177e878584016112e0565b8482015261020093508382015183811115611797578586fd5b6117a38882850161109d565b948201949094529695505050505050565b6001600160a01b03169052565b6000815180845260208401935060208301825b828110156117f25781518652602095860195909101906001016117d4565b5093949350505050565b6000815180845260208401935060208301825b828110156117f257815180518752602081015161182f6020890182611942565b5060408101516040880152606081015160608801526080810151608088015260a081015160a088015260c081015160c088015260e081015160e08801526101008082015161187f828a01826117b4565b505061012081810151908801526101408082015190880152610160808201516118aa828a018261192e565b505061018081810151908801526101a080820151908801526101c080820151908801526101e08082015190880152610200808201516118eb828a018261191a565b505061022080820151611900828a0182611920565b50505061024095909501946020919091019060010161180f565b15159052565b6004811061192a57fe5b9052565b6009811061192a57fe5b6003811061192a57fe5b60ff169052565b6001600160a01b0391909116815260200190565b901515815260200190565b90815260200190565b60006020825282602083015282846040840137818301604090810191909152601f909201601f19160101919050565b6000602082528251806020840152815b818110156119cd57602081860181015160408684010152016119b0565b818111156119de5782604083860101525b50601f01601f19169190910160400192915050565b60208082526024908201527f46756e6374696f6e2063616e206f6e6c792062652063616c6c65642062792065604082015263053686f760e41b606082015260800190565b6020808252601f908201527f6553686f7020686173206e6f2070757263686173696e67206164647265737300604082015260600190565b60208082526044908201527f436f756c64206e6f742066696e6420427573696e65737320506172746e65722060408201527f53746f7261676520636f6e7472616374206164647265737320696e20726567696060820152637374727960e01b608082015260a00190565b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b6020808252818101527f4e6f2071756f7465207369676e65727320666f756e6420666f72206553686f70604082015260600190565b600060208252825160208301526020830151611b6160408401826117b4565b506040830151611b7460608401826117b4565b506060830151611b8760808401826117b4565b50608083015160a083015260a083015160c083015260c083015160e083015260e0830151610100611bba818501836117b4565b84015161012084810191909152840151610140808501919091528401519050610160611be8818501836117b4565b8401519050610180611bfc84820183611938565b8401516101a08481019190915284015190506101c0611c1d81850183611942565b808501519150506102206101e08181860152611c3d6102408601846117fc565b90860151925061020090611c5386830185611942565b86820151868203601f1901848801529350610d3581856117c1565b91825260ff16602082015260400190565b93845260ff9290921660208401526040830152606082015260800190565b60405181810167ffffffffffffffff81118282101715611cbc57600080fd5b604052919050565b600067ffffffffffffffff821115611cda578081fd5b5060209081020190565b6001600160a01b03811681146103cb57600080fd5b60ff811681146103cb57600080fdfea26469706673582212202c573b4ef959372d59d9ae00e8d9e42d4aec1210bfe89377983b7659df706c8464736f6c63430006010033";
        public SellerAdminDeploymentBase() : base(BYTECODE) { }
        public SellerAdminDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "contractAddressOfRegistry", 1)]
        public virtual string ContractAddressOfRegistry { get; set; }
        [Parameter("string", "sellerIdString", 2)]
        public virtual string SellerIdString { get; set; }
    }

    public partial class BoundAddressCountFunction : BoundAddressCountFunctionBase { }

    [Function("BoundAddressCount", "int256")]
    public class BoundAddressCountFunctionBase : FunctionMessage
    {

    }

    public partial class BoundAddressesFunction : BoundAddressesFunctionBase { }

    [Function("BoundAddresses", "bool")]
    public class BoundAddressesFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class AddressRegistryFunction : AddressRegistryFunctionBase { }

    [Function("addressRegistry", "address")]
    public class AddressRegistryFunctionBase : FunctionMessage
    {

    }

    public partial class BindAddressFunction : BindAddressFunctionBase { }

    [Function("bindAddress")]
    public class BindAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "a", 1)]
        public virtual string A { get; set; }
    }

    public partial class BpStorageFunction : BpStorageFunctionBase { }

    [Function("bpStorage", "address")]
    public class BpStorageFunctionBase : FunctionMessage
    {

    }

    public partial class Bytes32ToStringFunction : Bytes32ToStringFunctionBase { }

    [Function("bytes32ToString", "string")]
    public class Bytes32ToStringFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "x", 1)]
        public virtual byte[] X { get; set; }
        [Parameter("uint256", "truncateToLength", 2)]
        public virtual BigInteger TruncateToLength { get; set; }
    }

    public partial class ConfigureFunction : ConfigureFunctionBase { }

    [Function("configure")]
    public class ConfigureFunctionBase : FunctionMessage
    {
        [Parameter("string", "nameOfBusinessPartnerStorage", 1)]
        public virtual string NameOfBusinessPartnerStorage { get; set; }
    }

    public partial class EmitEventForNewPoFunction : EmitEventForNewPoFunctionBase { }

    [Function("emitEventForNewPo")]
    public class EmitEventForNewPoFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class GetPoFunction : GetPoFunctionBase { }

    [Function("getPo", typeof(GetPoOutputDTO))]
    public class GetPoFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "poNumber", 2)]
        public virtual BigInteger PoNumber { get; set; }
    }

    public partial class GetPoByEshopIdAndQuoteFunction : GetPoByEshopIdAndQuoteFunctionBase { }

    [Function("getPoByEshopIdAndQuote", typeof(GetPoByEshopIdAndQuoteOutputDTO))]
    public class GetPoByEshopIdAndQuoteFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "quoteId", 2)]
        public virtual BigInteger QuoteId { get; set; }
    }

    public partial class IsOwnerFunction : IsOwnerFunctionBase { }

    [Function("isOwner", "bool")]
    public class IsOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class SellerIdFunction : SellerIdFunctionBase { }

    [Function("sellerId", "bytes32")]
    public class SellerIdFunctionBase : FunctionMessage
    {

    }

    public partial class SetPoItemAcceptedFunction : SetPoItemAcceptedFunctionBase { }

    [Function("setPoItemAccepted")]
    public class SetPoItemAcceptedFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "poNumber", 2)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 3)]
        public virtual byte PoItemNumber { get; set; }
        [Parameter("bytes32", "soNumber", 4)]
        public virtual byte[] SoNumber { get; set; }
        [Parameter("bytes32", "soItemNumber", 5)]
        public virtual byte[] SoItemNumber { get; set; }
    }

    public partial class SetPoItemCompletedFunction : SetPoItemCompletedFunctionBase { }

    [Function("setPoItemCompleted")]
    public class SetPoItemCompletedFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "poNumber", 2)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 3)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class SetPoItemGoodsIssuedFunction : SetPoItemGoodsIssuedFunctionBase { }

    [Function("setPoItemGoodsIssued")]
    public class SetPoItemGoodsIssuedFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "poNumber", 2)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 3)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class SetPoItemGoodsReceivedFunction : SetPoItemGoodsReceivedFunctionBase { }

    [Function("setPoItemGoodsReceived")]
    public class SetPoItemGoodsReceivedFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "poNumber", 2)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 3)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class SetPoItemReadyForGoodsIssueFunction : SetPoItemReadyForGoodsIssueFunctionBase { }

    [Function("setPoItemReadyForGoodsIssue")]
    public class SetPoItemReadyForGoodsIssueFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "poNumber", 2)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 3)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class SetPoItemRejectedFunction : SetPoItemRejectedFunctionBase { }

    [Function("setPoItemRejected")]
    public class SetPoItemRejectedFunctionBase : FunctionMessage
    {
        [Parameter("string", "eShopIdString", 1)]
        public virtual string EShopIdString { get; set; }
        [Parameter("uint256", "poNumber", 2)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 3)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class StringToBytes32Function : StringToBytes32FunctionBase { }

    [Function("stringToBytes32", "bytes32")]
    public class StringToBytes32FunctionBase : FunctionMessage
    {
        [Parameter("string", "source", 1)]
        public virtual string Source { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UnBindAddressFunction : UnBindAddressFunctionBase { }

    [Function("unBindAddress")]
    public class UnBindAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "a", 1)]
        public virtual string A { get; set; }
    }

    public partial class AddressAlreadyBoundEventDTO : AddressAlreadyBoundEventDTOBase { }

    [Event("AddressAlreadyBound")]
    public class AddressAlreadyBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressAlreadyUnBoundEventDTO : AddressAlreadyUnBoundEventDTOBase { }

    [Event("AddressAlreadyUnBound")]
    public class AddressAlreadyUnBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressBoundEventDTO : AddressBoundEventDTOBase { }

    [Event("AddressBound")]
    public class AddressBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressUnBoundEventDTO : AddressUnBoundEventDTOBase { }

    [Event("AddressUnBound")]
    public class AddressUnBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class QuoteConvertedToPoLogEventDTO : QuoteConvertedToPoLogEventDTOBase { }

    [Event("QuoteConvertedToPoLog")]
    public class QuoteConvertedToPoLogEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "eShopId", 1, true )]
        public virtual byte[] EShopId { get; set; }
        [Parameter("uint256", "quoteId", 2, true )]
        public virtual BigInteger QuoteId { get; set; }
        [Parameter("address", "buyerWalletAddress", 3, true )]
        public virtual string BuyerWalletAddress { get; set; }
    }

    public partial class BoundAddressCountOutputDTO : BoundAddressCountOutputDTOBase { }

    [FunctionOutput]
    public class BoundAddressCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BoundAddressesOutputDTO : BoundAddressesOutputDTOBase { }

    [FunctionOutput]
    public class BoundAddressesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class AddressRegistryOutputDTO : AddressRegistryOutputDTOBase { }

    [FunctionOutput]
    public class AddressRegistryOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class BpStorageOutputDTO : BpStorageOutputDTOBase { }

    [FunctionOutput]
    public class BpStorageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class Bytes32ToStringOutputDTO : Bytes32ToStringOutputDTOBase { }

    [FunctionOutput]
    public class Bytes32ToStringOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class GetPoOutputDTO : GetPoOutputDTOBase { }

    [FunctionOutput]
    public class GetPoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class GetPoByEshopIdAndQuoteOutputDTO : GetPoByEshopIdAndQuoteOutputDTOBase { }

    [FunctionOutput]
    public class GetPoByEshopIdAndQuoteOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class IsOwnerOutputDTO : IsOwnerOutputDTOBase { }

    [FunctionOutput]
    public class IsOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SellerIdOutputDTO : SellerIdOutputDTOBase { }

    [FunctionOutput]
    public class SellerIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }













    public partial class StringToBytes32OutputDTO : StringToBytes32OutputDTOBase { }

    [FunctionOutput]
    public class StringToBytes32OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "result", 1)]
        public virtual byte[] Result { get; set; }
    }




}
