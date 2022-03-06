
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.exceptions {
	public class PosException : global::haxe.Exception {
		
		public PosException(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public PosException(string message, global::haxe.Exception previous, object pos) : base(((string) (message) ), ((global::haxe.Exception) (( (( previous == null )) ? (null) : (previous) )) ), default(object)) {
			if (( pos == null )) {
				this.posInfos = new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"(unknown)", "(unknown)", "(unknown)"}, new int[]{1981972957}, new double[]{((double) (0) )});
			}
			else {
				this.posInfos = pos;
			}
			
		}
		
		
		public object posInfos;
		
		public override string toString() {
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("", base.toString()), " in "), global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.posInfos, "className", 1547539107, true))), "."), global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.posInfos, "methodName", 302979532, true))), " at "), global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(this.posInfos, "fileName", 1648581351, true))), ":"), global::haxe.lang.Runtime.toString(((int) (global::haxe.lang.Runtime.getField_f(this.posInfos, "lineNumber", 1981972957, true)) )));
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1512997393:
					{
						this.posInfos = ((object) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1512997393:
					{
						this.posInfos = ((object) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1512997393:
					{
						return this.posInfos;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1512997393:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.posInfos)) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			baseArr.push("posInfos");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


