using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using тема_1;


namespace тема2
{
	public partial class SignIn_Up : Form
	{
		// Элементы управления для входа
		private Panel pnlLogin;
		private TextBox txtLoginUsername;
		private TextBox txtLoginPassword;
		private Button btnLogin;
		private LinkLabel linkToRegister;

		// Элементы управления для регистрации
		private Panel pnlRegister;
		private TextBox txtRegFirstName;
		private TextBox txtRegLastName;
		private TextBox txtRegUsername;
		private TextBox txtRegPassword;
		private TextBox txtRegPhone;
		private Button btnRegister;
		private LinkLabel linkToLogin;

		public SignIn_Up()
		{
			InitializeComponent();
			InitializeLoginForm();
			InitializeRegisterForm();
			ShowLoginForm();
		}

		private void InitializeLoginForm()
		{
			// УВЕЛИЧЕННАЯ панель входа
			pnlLogin = new Panel
			{
				Size = new Size(500, 400),  // Увеличено с 350x300
				Location = new Point(50, 50), // Смещено для центрирования
				BorderStyle = BorderStyle.FixedSingle,
				BackColor = Color.White
			};

			// Заголовок - перемещен выше
			Label lblLoginTitle = new Label
			{
				Text = "Вход в систему психологического тестирования",
				Font = new Font("Arial", 16, FontStyle.Bold),
				Location = new Point(50, 40), // Поднят выше
				Size = new Size(400, 30),
				TextAlign = ContentAlignment.MiddleCenter
			};

			// Поле логина - больше отступы
			Label lblUsername = new Label
			{
				Text = "Логин:",
				Location = new Point(100, 100), // Смещено вправо
				Size = new Size(100, 25),
				Font = new Font("Arial", 11)
			};

			txtLoginUsername = new TextBox
			{
				Location = new Point(100, 130), // Смещено вправо
				Size = new Size(300, 35), // Увеличено
				Font = new Font("Arial", 11)
			};

			// Поле пароля - больше отступы
			Label lblPassword = new Label
			{
				Text = "Пароль:",
				Location = new Point(100, 180), // Смещено вправо
				Size = new Size(100, 25),
				Font = new Font("Arial", 11)
			};

			txtLoginPassword = new TextBox
			{
				Location = new Point(100, 210), // Смещено вправо
				Size = new Size(300, 35), // Увеличено
				Font = new Font("Arial", 11),
				UseSystemPasswordChar = true
			};

			// Кнопка входа - увеличена
			btnLogin = new Button
			{
				Text = "Войти",
				Location = new Point(100, 270), // Смещено вниз
				Size = new Size(300, 45), // Увеличена
				BackColor = Color.SteelBlue,
				ForeColor = Color.White,
				Font = new Font("Arial", 12, FontStyle.Bold), // Увеличено
				Cursor = Cursors.Hand
			};
			btnLogin.Click += BtnLogin_Click;

			// Ссылка на регистрацию - смещена вниз
			linkToRegister = new LinkLabel
			{
				Text = "Нет аккаунта? Зарегистрируйтесь",
				Location = new Point(150, 330), // Смещено вниз
				Size = new Size(200, 25),
				TextAlign = ContentAlignment.MiddleCenter,
				Font = new Font("Arial", 10) // Увеличено
			};
			linkToRegister.LinkClicked += LinkToRegister_LinkClicked;

			// Добавляем элементы на панель входа
			pnlLogin.Controls.AddRange(new Control[] {
				lblLoginTitle, lblUsername, txtLoginUsername,
				lblPassword, txtLoginPassword, btnLogin, linkToRegister
			});

			this.Controls.Add(pnlLogin);
		}

		private void InitializeRegisterForm()
		{
			// УВЕЛИЧЕННАЯ панель регистрации
			pnlRegister = new Panel
			{
				Size = new Size(500, 600), // Увеличено с 350x450
				Location = new Point(50, 50), // Смещено для центрирования
				BorderStyle = BorderStyle.FixedSingle,
				BackColor = Color.White,
				Visible = false
			};

			// Заголовок - перемещен выше
			Label lblRegTitle = new Label
			{
				Text = "Регистрация в системе психологического тестирования",
				Font = new Font("Arial", 16, FontStyle.Bold),
				Location = new Point(50, 30), // Поднят выше
				Size = new Size(400, 30),
				TextAlign = ContentAlignment.MiddleCenter
			};

			// Поле имени - больше отступы
			Label lblFirstName = new Label
			{
				Text = "Имя:",
				Location = new Point(100, 80), // Смещено вправо
				Size = new Size(100, 25),
				Font = new Font("Arial", 11)
			};

			txtRegFirstName = new TextBox
			{
				Location = new Point(100, 110), // Смещено вправо
				Size = new Size(300, 35), // Увеличено
				Font = new Font("Arial", 11)
			};

			// Поле фамилии - больше отступы
			Label lblLastName = new Label
			{
				Text = "Фамилия:",
				Location = new Point(100, 160), // Смещено вправо
				Size = new Size(100, 25),
				Font = new Font("Arial", 11)
			};

			txtRegLastName = new TextBox
			{
				Location = new Point(100, 190), // Смещено вправо
				Size = new Size(300, 35), // Увеличено
				Font = new Font("Arial", 11)
			};

			// Поле логина - больше отступы
			Label lblRegUsername = new Label
			{
				Text = "Логин:",
				Location = new Point(100, 240), // Смещено вправо
				Size = new Size(100, 25),
				Font = new Font("Arial", 11)
			};

			txtRegUsername = new TextBox
			{
				Location = new Point(100, 270), // Смещено вправо
				Size = new Size(300, 35), // Увеличено
				Font = new Font("Arial", 11)
			};

			// Поле пароля - больше отступы
			Label lblRegPassword = new Label
			{
				Text = "Пароль:",
				Location = new Point(100, 320), // Смещено вправо
				Size = new Size(100, 25),
				Font = new Font("Arial", 11)
			};

			txtRegPassword = new TextBox
			{
				Location = new Point(100, 350), // Смещено вправо
				Size = new Size(300, 35), // Увеличено
				Font = new Font("Arial", 11),
				UseSystemPasswordChar = true
			};

			// Поле телефона - больше отступы
			Label lblPhone = new Label
			{
				Text = "Номер телефона:",
				Location = new Point(100, 400), // Смещено вправо
				Size = new Size(150, 25),
				Font = new Font("Arial", 11)
			};

			txtRegPhone = new TextBox
			{
				Location = new Point(100, 430), // Смещено вправо
				Size = new Size(300, 35), // Увеличено
				Font = new Font("Arial", 11),
				PlaceholderText = "+375XXXXXXXXX"
			};

			// Кнопка регистрации - увеличена
			btnRegister = new Button
			{
				Text = "Зарегистрироваться",
				Location = new Point(100, 490), // Смещено вниз
				Size = new Size(300, 45), // Увеличена
				BackColor = Color.SeaGreen,
				ForeColor = Color.White,
				Font = new Font("Arial", 12, FontStyle.Bold), // Увеличено
				Cursor = Cursors.Hand
			};
			btnRegister.Click += BtnRegister_Click;

			// Ссылка на вход - смещена вниз
			linkToLogin = new LinkLabel
			{
				Text = "Уже есть аккаунт? Войдите",
				Location = new Point(150, 550), // Смещено вниз
				Size = new Size(200, 25),
				TextAlign = ContentAlignment.MiddleCenter,
				Font = new Font("Arial", 10) // Увеличено
			};
			linkToLogin.LinkClicked += LinkToLogin_LinkClicked;

			// Добавляем элементы на панель регистрации
			pnlRegister.Controls.AddRange(new Control[] {
				lblRegTitle, lblFirstName, txtRegFirstName,
				lblLastName, txtRegLastName, lblRegUsername, txtRegUsername,
				lblRegPassword, txtRegPassword, lblPhone, txtRegPhone,
				btnRegister, linkToLogin
			});

			this.Controls.Add(pnlRegister);
		}

		private void ShowLoginForm()
		{
			pnlLogin.Visible = true;
			pnlRegister.Visible = false;
			// УВЕЛИЧЕН размер формы для входа
			this.Size = new Size(600, 500); // Было 400x370
			this.Text = "Вход в систему психологического тестирования";
			CenterToScreen();
		}

		private void ShowRegisterForm()
		{
			pnlLogin.Visible = false;
			pnlRegister.Visible = true;
			// УВЕЛИЧЕН размер формы для регистрации
			this.Size = new Size(600, 700); // Было 400x520
			this.Text = "Регистрация в системе психологического тестирования";
			CenterToScreen();
		}

		// Остальной код без изменений...
		private void LinkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowRegisterForm();
		}

		private void LinkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShowLoginForm();
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			string username = txtLoginUsername.Text.Trim();
			string password = txtLoginPassword.Text;

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			CheckLoginPassword(username, password);
		}

		private void CheckLoginPassword(string login, string password)
		{
			BDConnection database = new BDConnection();
			DataTable dataTable = new DataTable();

			try
			{
				database.openConnection();

				MySqlCommand command = new MySqlCommand(
					"SELECT * FROM users WHERE login = @ent_login AND password = @ent_password",
					database.getConnection());

				command.Parameters.Add("@ent_login", MySqlDbType.VarChar).Value = login;
				command.Parameters.Add("@ent_password", MySqlDbType.VarChar).Value = HashPassword(password);

				MySqlDataAdapter adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

				if (dataTable.Rows.Count > 0)
				{
					DataRow user = dataTable.Rows[0];
					string firstName = user["first_name"].ToString();
					string lastName = user["last_name"].ToString();

					MessageBox.Show($"{firstName} {lastName}, Вы успешно авторизовались!",
						"Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

					this.Hide();
					MainWindow main = new MainWindow();
					main.Show();
				}
				else
				{
					MessageBox.Show($"Неверный логин или пароль",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				database.closeConnection();
			}
		}

		private void BtnRegister_Click(object sender, EventArgs e)
		{
			string firstName = txtRegFirstName.Text.Trim();
			string lastName = txtRegLastName.Text.Trim();
			string username = txtRegUsername.Text.Trim();
			string password = txtRegPassword.Text;
			string phone = txtRegPhone.Text.Trim();

			if (!ValidateRegistrationData(firstName, lastName, username, password, phone))
				return;

			try
			{
				RegisterNewUser(firstName, lastName, username, password, phone);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при регистрации: {ex.Message}",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateRegistrationData(string firstName, string lastName, string username, string password, string phone)
		{
			if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
				string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Пожалуйста, заполните все обязательные поля",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (password.Length < 6)
			{
				MessageBox.Show("Пароль должен содержать минимум 6 символов",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (!string.IsNullOrEmpty(phone) && !IsValidPhoneNumber(phone))
			{
				MessageBox.Show("Введите корректный номер телефона в формате +375XXXXXXXXX",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		private void RegisterNewUser(string firstName, string lastName, string username, string password, string phone)
		{
			BDConnection database = new BDConnection();

			try
			{
				database.openConnection();

				if (IsUsernameTaken(username, database))
				{
					MessageBox.Show("Этот логин уже занят. Выберите другой.",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string query = @"INSERT INTO users (first_name, last_name, login, password, phone) 
                              VALUES (@firstName, @lastName, @username, @password, @phone)";

				MySqlCommand command = new MySqlCommand(query, database.getConnection());
				command.Parameters.AddWithValue("@firstName", firstName);
				command.Parameters.AddWithValue("@lastName", lastName);
				command.Parameters.AddWithValue("@username", username);
				command.Parameters.AddWithValue("@password", HashPassword(password));
				command.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(phone) ? DBNull.Value : phone);

				int rowsAffected = command.ExecuteNonQuery();

				if (rowsAffected > 0)
				{
					MessageBox.Show("Регистрация прошла успешно! Теперь вы можете войти в систему.",
						"Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ClearRegistrationFields();
					ShowLoginForm();
				}
			}
			finally
			{
				database.closeConnection();
			}
		}

		private bool IsUsernameTaken(string username, BDConnection database)
		{
			string checkQuery = "SELECT COUNT(*) FROM users WHERE login = @username";
			MySqlCommand checkCommand = new MySqlCommand(checkQuery, database.getConnection());
			checkCommand.Parameters.AddWithValue("@username", username);

			int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());
			return userCount > 0;
		}

		private bool IsValidPhoneNumber(string phone)
		{
			string pattern = @"^\+375(25|29|33|44)\d{7}$";
			return Regex.IsMatch(phone, pattern);
		}

		private string HashPassword(string password)
		{
			using (var sha256 = System.Security.Cryptography.SHA256.Create())
			{
				var bytes = System.Text.Encoding.UTF8.GetBytes(password);
				var hash = sha256.ComputeHash(bytes);
				return Convert.ToBase64String(hash);
			}
		}

		private void ClearRegistrationFields()
		{
			txtRegFirstName.Text = "";
			txtRegLastName.Text = "";
			txtRegUsername.Text = "";
			txtRegPassword.Text = "";
			txtRegPhone.Text = "";
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// SignIn_Up
			// 
			this.BackColor = Color.LightGray;
			// Начальный размер увеличен
			this.ClientSize = new Size(600, 500);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Вход в систему психологического тестирования";
			this.ResumeLayout(false);
		}
	}
}