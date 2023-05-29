using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C_小区物业管理
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        // 添加省份下拉框控件
        private void AddProvinces()
        {
            List<string> provinces = GetProvinces();
            provinceComboBox.Items.AddRange(provinces.ToArray());
        }

        // 添加城市下拉框控件
        private void AddCities(string province)
        {
            List<string> cities = GetCities(province);
            cityComboBox.Items.Clear();
            cityComboBox.Items.AddRange(cities.ToArray());
        }

        // 获取省份列表
        private List<string> GetProvinces()
        {
            return new List<string>() 
            { "北京市", "天津市", "上海市", "重庆市", "河北省", "山西省", 
                "辽宁省", "吉林省", "黑龙江省", "江苏省", "浙江省", "安徽省", 
                "福建省", "江西省", "山东省", "河南省", "湖北省", "湖南省", 
                "广东省", "广西壮族自治区", "海南省", "四川省", "贵州省", 
                "云南省", "西藏自治区", "陕西省", "甘肃省", "青海省", 
                "宁夏回族自治区", "新疆维吾尔自治区"
            };
        }

        // 获取城市列表
        private List<string> GetCities(string province)
        {
            switch (province)
            {
                case "北京市":
                    return new List<string>() {
                "北京市"
        };

                case "天津市":
                    return new List<string>() {
                "天津市"
        };

                case "上海市":
                    return new List<string>() {
                "上海市"
        };

                case "重庆市":
                    return new List<string>() {
                "重庆市"
        };

                case "河北省":
                    return new List<string>() {
                "石家庄市",
                "唐山市",
                "秦皇岛市",
                "邯郸市",
                "邢台市",
                "保定市",
                "张家口市",
                "承德市",
                "沧州市",
                "廊坊市",
                "衡水市"
        };

                case "山西省":
                    return new List<string>() {
                "太原市",
                "大同市",
                "阳泉市",
                "长治市",
                "晋城市",
                "朔州市",
                "晋中市",
                "运城市",
                "忻州市",
                "临汾市",
                "吕梁市"
        };

                case "辽宁省":
                    return new List<string>() {
                "沈阳市",
                "大连市",
                "鞍山市",
                "抚顺市",
                "本溪市",
                "丹东市",
                "锦州市",
                "营口市",
                "阜新市",
                "辽阳市",
                "盘锦市",
                "铁岭市",
                "朝阳市",
                "葫芦岛市"
        };

                case "吉林省":
                    return new List<string>() {
                "长春市",
                "吉林市",
                "四平市",
                "辽源市",
                "通化市",
                "白山市",
                "松原市",
                "白城市",
                "延边朝鲜族自治州"
        };

                case "黑龙江省":
                    return new List<string>() {
                "哈尔滨市",
                "齐齐哈尔市",
                "鸡西市",
                "鹤岗市",
                "双鸭山市",
                "大庆市",
                "伊春市",
                "佳木斯市",
                "七台河市",
                "牡丹江市",
                "黑河市",
                "绥化市",
                "大兴安岭地区"
        };

                case "江苏省":
                    return new List<string>() {
                "南京市",
                "无锡市",
                "徐州市",
                "常州市",
                "苏州市",
                "南通市",
                "连云港市",
                "淮安市",
                "盐城市",
                "扬州市",
                "镇江市",
                "泰州市",
                "宿迁市"
        };

                case "浙江省":
                    return new List<string>() {
                "杭州市",
                "宁波市",
                "温州市",
                "嘉兴市",
                "湖州市",
                "绍兴市",
                "舟山市",
                "丽水市",
                "金华市",
                "衢州市",
                "台州市"
        };

                case "安徽省":
                    return new List<string>() {
                "合肥市",
                "芜湖市",
                "蚌埠市",
                "淮南市",
                "马鞍山市",
                "淮北市",
                "铜陵市",
                "安庆市",
                "黄山市",
                "滁州市",
                "阜阳市",
                "宿州市",
                "六安市",
                "亳州市",
                "池州市",
                "宣城市"
        };

                case "福建省":
                    return new List<string>() {
                "福州市",
                "厦门市",
                "莆田市",
                "三明市",
                "泉州市",
                "漳州市",
                "南平市",
                "龙岩市",
                "宁德市"
        };

                case "江西省":
                    return new List<string>() {
                "南昌市",
                "景德镇市",
                "萍乡市",
                "九江市",
                "新余市",
                "鹰潭市",
                "赣州市",
                "吉安市",
                "宜春市",
                "抚州市",
                "上饶市"
        };

                case "山东省":
                    return new List<string>() {
                "济南市",
                "青岛市",
                "淄博市",
                "枣庄市",
                "东营市",
                "烟台市",
                "潍坊市",
                "济宁市",
                "泰安市",
                "威海市",
                "日照市",
                "莱芜市",
                "临沂市",
                "德州市",
                "聊城市",
                "滨州市",
                "菏泽市"
        };

                case "河南省":
                    return new List<string>() {
                "郑州市",
                "开封市",
                "洛阳市",
                "平顶山市",
                "安阳市",
                "鹤壁市",
                "新乡市",
                "焦作市",
                "濮阳市",
                "许昌市",
                "漯河市",
                "三门峡市",
                "南阳市",
                "商丘市",
                "信阳市",
                "周口市",
                "驻马店市",
                "省直辖县级行政区划"
        };

                case "湖北省":
                    return new List<string>() {
                "武汉市",
                "黄石市",
                "十堰市",
                "宜昌市",
                "襄阳市",
                "鄂州市",
                "荆门市",
                "孝感市",
                "荆州市",
                "黄冈市",
                "咸宁市",
                "随州市",
                "恩施土家族苗族自治州",
                "省直辖县级行政区划"
        };

                case "湖南省":
                    return new List<string>() {
                "长沙市",
                "株洲市",
                "湘潭市",
                "衡阳市",
                "邵阳市",
                "岳阳市",
                "常德市",
                "张家界市",
                "益阳市",
                "郴州市",
                "永州市",
                "怀化市",
                "娄底市",
                "湘西土家族苗族自治州"
        };

                case "广东省":
                    return new List<string>() {
                "广州市",
                "深圳市",
                "珠海市",
                "汕头市",
                "韶关市",
                "佛山市",
                "江门市",
                "湛江市",
                "茂名市",
                "肇庆市",
                "惠州市",
                "梅州市",
                "汕尾市",
                "河源市",
                "阳江市",
                "清远市",
                "东莞市",
                "中山市",
                "潮州市",
                "揭阳市",
                "云浮市"
        };

                case "广西壮族自治区":
                    return new List<string>() {
                "南宁市",
                "柳州市",
                "桂林市",
                "梧州市",
                "北海市",
                "防城港市",
                "钦州市",
                "贵港市",
                "玉林市",
                "百色市",
                "贺州市",
                "河池市",
                "来宾市",
                "崇左市"
        };

                case "海南省":
                    return new List<string>() {
                "海口市",
                "三亚市",
                "三沙市",
                "儋州市",
                "省直辖县级行政区划"
        };

                case "四川省":
                    return new List<string>() {
                "成都市",
                "自贡市",
                "攀枝花市",
                "泸州市",
                "德阳市",
                "绵阳市",
                "广元市",
                "遂宁市",
                "内江市",
                "乐山市",
                "南充市",
                "眉山市",
                "宜宾市",
                "广安市",
                "达州市",
                "雅安市",
                "巴中市",
                "资阳市",
                "阿坝藏族羌族自治州",
                "甘孜藏族自治州",
                "凉山彝族自治州"
        };

                case "贵州省":
                    return new List<string>() {
                "贵阳市",
                "六盘水市",
                "遵义市",
                "安顺市",
                "毕节市",
                "铜仁市",
                "黔西南布依族苗族自治州",
                "黔东南苗族侗族自治州",
                "黔南布依族苗族自治州"
        };

                case "云南省":
                    return new List<string>() {
                "昆明市",
                "曲靖市",
                "玉溪市",
                "保山市",
                "昭通市",
                "丽江市",
                "普洱市",
                "临沧市",
                "楚雄彝族自治州",
                "红河哈尼族彝族自治州",
                "文山壮族苗族自治州",
                "西双版纳傣族自治州",
                "大理白族自治州",
                "德宏傣族景颇族自治州",
                "怒江傈僳族自治州",
                "迪庆藏族自治州"
        };

                case "西藏自治区":
                    return new List<string>() {
                "拉萨市",
                "日喀则市",
                "昌都市",
                "林芝市",
                "山南地区",
                "那曲地区",
                "阿里地区"
        };

                case "陕西省":
                    return new List<string>() {
                "西安市",
                "铜川市",
                "宝鸡市",
                "咸阳市",
                "渭南市",
                "延安市",
                "汉中市",
                "榆林市",
                "安康市",
                "商洛市"
        };

                case "甘肃省":
                    return new List<string>() {
                "兰州市",
                "嘉峪关市",
                "金昌市",
                "白银市",
                "天水市",
                "武威市",
                "张掖市",
                "平凉市",
                "酒泉市",
                "庆阳市",
                "定西市",
                "陇南市",
                "临夏回族自治州",
                "甘南藏族自治州"
        };

                case "青海省":
                    return new List<string>() {
                "西宁市",
                "海东市",
                "海北藏族自治州",
                "黄南藏族自治州",
                "海南藏族自治州",
                "果洛藏族自治州",
                "玉树藏族自治州",
                "海西蒙古族藏族自治州"
        };

                case "宁夏回族自治区":
                    return new List<string>() {
                "银川市",
                "石嘴山市",
                "吴忠市",
                "固原市",
                "中卫市"
        };

                case "新疆维吾尔自治区":
                    return new List<string>() {
                "乌鲁木齐市",
                "克拉玛依市",
                "吐鲁番市",
                "哈密市",
                "昌吉回族自治州",
                "博尔塔拉蒙古自治州",
                "巴音郭楞蒙古自治州",
                "阿克苏地区",
                "克孜勒苏柯尔克孜自治州",
                "喀什地区",
                "和田地区",
                "伊犁哈萨克自治州",
                "塔城地区",
                "阿勒泰地区",
                "省直辖县级行政区划"
        };
                default:
                    return new List<string>();
            }
        }


        // 获取公司地址
        private string GetCompanyAddress()
        {
            string province = provinceComboBox.SelectedItem as string;
            string city = cityComboBox.SelectedItem as string;
            string address = companyAddressTxtBox.Text.Trim();

            return $"{province}{city}{address}";
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();
            string confirmPassword = confirmPasswordTxtBox.Text.Trim();
            string companyName = companyNameTxtBox.Text.Trim();
            string companyAddress = GetCompanyAddress();
            string companyPhone = companyPhoneTxtBox.Text.Trim();
            string companyPostalCode = companyPostalCodeTxtBox.Text.Trim();
            string legalIdCard = legalIdCardTxtBox.Text.Trim();
            string legalName = legalNameTxtBox.Text.Trim();
            string email = emailTxtBox.Text.Trim();
            string captcha = captchaTxtBox.Text.Trim();
            bool agreeProtocol = agreeCheckBox.Checked;

            // 检查必填项是否为空
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(companyName) ||
                string.IsNullOrEmpty(companyAddress) || string.IsNullOrEmpty(companyPhone) ||
                string.IsNullOrEmpty(companyPostalCode) || string.IsNullOrEmpty(legalIdCard) ||
                string.IsNullOrEmpty(legalName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(captcha))
            {
                MessageBox.Show("请填写完整信息！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查用户名格式是否正确
            if (!Regex.IsMatch(username, "^[a-zA-Z][a-zA-Z0-9]{3,15}$"))
            {
                MessageBox.Show("用户名格式不正确，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查密码格式是否正确
            if (!Regex.IsMatch(password, "^[a-zA-Z0-9]{6,20}$"))
            {
                MessageBox.Show("密码格式不正确，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查确认密码和密码是否一致
            if (password != confirmPassword)
            {
                MessageBox.Show("两次密码不一致，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查公司电话号码格式是否正确
            if (!Regex.IsMatch(companyPhone, "^\\d{7,14}$"))
            {
                MessageBox.Show("电话号码有误，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查公司邮编格式是否正确
            if (!Regex.IsMatch(companyPostalCode, "^\\d{6}$"))
            {
                MessageBox.Show("邮编错误，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查法人身份证格式是否正确
            if (!Regex.IsMatch(legalIdCard, "^\\d{16}$|^\\d{18}$"))
            {
                MessageBox.Show("身份证错误，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查邮箱格式是否正确
            if (!Regex.IsMatch(email, "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$"))
            {
                MessageBox.Show("邮箱有误，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查是否同意协议
            if (!agreeProtocol)
            {
                MessageBox.Show("请阅读并同意协议！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 检查验证码是否正确
            if (!VerifyCaptcha(captcha))
            {
                MessageBox.Show("验证码错误，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GenerateCode();
                return;
            }

            bool success = Register(username, password, companyName, companyAddress, companyPhone,
                companyPostalCode, legalIdCard, legalName, email);
            if (success)
            {
                MessageBox.Show("注册成功！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("注册失败，请重试！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 检查验证码是否正确
        private bool VerifyCaptcha(string inputCaptcha)
        {
            // 比较输入的验证码和系统生成的验证码是否一致
            return string.Equals(inputCaptcha, systemCaptcha, StringComparison.InvariantCultureIgnoreCase);
        }

        // 获取系统生成的验证码
        public static string systemCaptcha = VerificationCode.GetSystemCaptcha();

        //生成验证码图片并显示到pictureBox1
        public void GenerateCode()
        {  
            byte[] bytes = VerificationCode.GenerateImg(systemCaptcha);
            MemoryStream ms = new MemoryStream(bytes);
            Image image = Image.FromStream(ms);
            pictureBox1.Image = image;
        }
        // 执行插入语句注册用户信息
        private bool Register(string username, string password, string companyName,
            string companyAddress, string companyPhone, string companyPostalCode,
            string legalIdCard, string legalName, string email)
        {
            // SQL 语句插入注册信息
            string sql = string.Format("INSERT INTO GuanLiYuan VALUES ('{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}', '{7}', '{8}',3)", username, password, companyName, companyAddress, companyPhone, companyPostalCode, legalIdCard, legalName, email);
            int rows = DbHelper.ExecuteNonQuery(sql);
            return rows > 0;

        }

        //单击图片时刷新验证码
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            systemCaptcha = VerificationCode.GetSystemCaptcha();
            GenerateCode();
        }

        //加载窗口的时候运行
        private void Registration_Load(object sender, EventArgs e)
        {
            AddProvinces();
            GenerateCode();
        }

        //选择省份时候运行
        private void provinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.Text = null;
            string selectedProvince = provinceComboBox.SelectedItem as string;
            AddCities(selectedProvince);
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            //终止当前窗口
            Close();
        }
    }
}
