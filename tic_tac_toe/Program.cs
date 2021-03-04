using System;

namespace tic_tac_toe
{
	class Program
	{
		static void print(string[,] field)
		{
			Console.WriteLine("\n");
			for (int i = 0; i < 3; i++, Console.WriteLine())
				for (int j = 0; j < 3; j++)
					Console.Write("{0,3}", field[i, j]);
			Console.WriteLine("\n");
		}

		static void Main(string[] args)
		{
			string[,] field = new string[3, 3] { { "_1_|", "_2_|", "_3_" }, { "_4_|", "_X_|", "_6_" }, { " 7 |", " 8 |", " 9 " } };
			print(field);
			Console.WriteLine("write cell number \n");
			bool run = true;
			string number_cell;
			while (run)
			{
				run = false;
				number_cell = Console.ReadLine();
				switch (number_cell)
				{
					case "1":
						{
							field[0, 0] = "_O_|";
							print(field);
							field[0, 2] = "_X_";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "2":
										{
											field[0, 1] = "_O_|";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "4":
										{
											field[1, 0] = "_O_|";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "6":
										{
											field[1, 2] = "_O_";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "7":
										{
											field[2, 0] = " O |";
											print(field);
											field[1, 0] = "_X_|";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "2":
														{
															field[0, 1] = "_O_|";
															print(field);
															field[1, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "6":
														{
															field[1, 2] = "_O_";
															print(field);
															field[0, 1] = "_X_|";
															print(field);
															Console.WriteLine("write cell number \n");
															run = true;
															while (run)
															{
																run = false;
																number_cell = Console.ReadLine();
																switch (number_cell)
																{
																	case "8":
																		{
																			field[2, 1] = " O |";
																			print(field);
																			field[2, 2] = " X ";
																			print(field);
																			Console.WriteLine("draw, congratulations! \n");
																			break;
																		}
																	case "9":
																		{
																			field[2, 2] = " O ";
																			print(field);
																			field[2, 1] = " X |";
																			print(field);
																			Console.WriteLine("you lose \n");
																			break;
																		}
																	default:
																		Console.WriteLine("try again \n");
																		run = true;
																		break;
																}
															}
															break;
														}
													case "8":
														{
															field[2, 1] = " O |";
															print(field);
															field[1, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "9":
														{
															field[2, 2] = " O ";
															print(field);
															field[1, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									case "8":
										{
											field[2, 1] = " O |";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "9":
										{
											field[2, 2] = " O ";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					case "2":
						{
							field[0, 1] = "_O_|";
							print(field);
							field[2, 0] = " X |";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "1":
										{
											field[0, 0] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "3":
										{
											field[0, 2] = "_O_";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "4":
														{
															field[1, 0] = "_O_|";
															print(field);
															field[2, 2] = " X ";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "6":
														{
															field[1, 1] = "_O_";
															print(field);
															field[2, 2] = " X ";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "8":
														{
															field[2, 1] = " O |";
															print(field);
															field[1, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "9":
														{
															field[2, 2] = " O ";
															print(field);
															field[1, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									case "4":
										{
											field[1, 0] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "6":
										{
											field[1, 2] = "_O_";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "8":
										{
											field[2, 1] = " O |";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "9":
										{
											field[2, 2] = " O ";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					case "3":
						{
							field[0, 2] = "_O_";
							print(field);
							field[0, 0] = "_X_|";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "2":
										{
											field[0, 1] = "_O_|";
											print(field);
											field[2, 2] = " X ";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "4":
										{
											field[1, 0] = "_O_|";
											print(field);
											field[2, 2] = " X ";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "6":
										{
											field[1, 2] = "_O_";
											print(field);
											field[2, 2] = " X ";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "7":
										{
											field[2, 0] = " O |";
											print(field);
											field[2, 2] = " X ";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "8":
										{
											field[2, 1] = " O |";
											print(field);
											field[2, 2] = " X ";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "9":
										{
											field[2, 2] = " O ";
											print(field);
											field[1, 2] = "_X_";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "2":
														{
															field[0, 1] = "_O_|";
															print(field);
															field[1, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "4":
														{
															field[1, 0] = "_O_|";
															print(field);
															field[0, 1] = "_X_|";
															print(field);
															Console.WriteLine("write cell number \n");
															run = true;
															while (run)
															{
																run = false;
																number_cell = Console.ReadLine();
																switch (number_cell)
																{
																	case "7":
																		{
																			field[2, 0] = " O |";
																			print(field);
																			field[2, 1] = " X |";
																			print(field);
																			Console.WriteLine("you lose \n");
																			break;
																		}
																	case "8":
																		{
																			field[2, 1] = " O |";
																			print(field);
																			field[2, 0] = " X |";
																			print(field);
																			Console.WriteLine("draw, congratulations! \n");
																			break;

																		}
																	default:
																		Console.WriteLine("try again \n");
																		run = true;
																		break;
																}
															}
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					case "4":
						{
							field[1, 0] = "_O_|";
							print(field);
							field[2, 2] = " X ";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "1":
										{
											field[0, 0] = "_O_|";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "2":
														{
															field[0, 1] = "_O_|";
															print(field);
															field[2, 1] = " X |";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "3":
														{
															field[0, 2] = "_O_";
															print(field);
															field[2, 1] = " X |";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "6":
														{
															field[2, 1] = "_O_";
															print(field);
															field[0, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "8":
														{
															field[2, 1] = " O |";
															print(field);
															field[0, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									case "2":
										{
											field[0, 1] = "_O_|";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "3":
										{
											field[0, 2] = "_O_";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "6":
										{
											field[1, 2] = "_O_";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "7":
										{
											field[2, 0] = " O |";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "8":
										{
											field[2, 1] = " O |";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					case "6":
						{
							field[1, 2] = "_O_";
							field[2, 0] = " X |";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "1":
										{
											field[0, 0] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "2":
										{
											field[0, 1] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "3":
										{
											field[0, 2] = "_O_";
											print(field);
											field[2, 2] = " X ";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "1":
														{
															field[0, 0] = "_O_|";
															print(field);
															field[2, 1] = " X |";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "2":
														{
															field[0, 1] = "_O_|";
															print(field);
															field[2, 1] = " X |";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "4":
														{
															field[1, 0] = "_O_|";
															print(field);
															field[0, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "8":
														{
															field[2, 1] = " O |";
															print(field);
															field[0, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									case "4":
										{
											field[1, 0] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "8":
										{
											field[2, 1] = " O |";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "9":
										{
											field[2, 2] = " O ";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					case "7":
						{
							field[2, 0] = " O |";
							print(field);
							field[2, 2] = " X ";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "1":
										{
											field[0, 0] = "_O_|";
											print(field);
											field[1, 0] = "_X_|";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "2":
														{
															field[0, 1] = "_O_|";
															print(field);
															field[1, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "3":
														{
															field[0, 2] = "_O_";
															print(field);
															field[1, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "6":
														{
															field[1, 2] = "_O_";
															print(field);
															field[0, 1] = "_X_|";
															print(field);
															Console.WriteLine("write cell number \n");
															run = true;
															while (run)
															{
																run = false;
																number_cell = Console.ReadLine();
																switch (number_cell)
																{
																	case "3":
																		{
																			field[0, 2] = "_O_";
																			print(field);
																			field[2, 1] = " X |";
																			print(field);
																			Console.WriteLine("you lose \n");
																			break;
																		}
																	case "8":
																		{
																			field[2, 1] = " O |";
																			print(field);
																			field[0, 2] = "_X_";
																			print(field);
																			Console.WriteLine("draw, congratulations! \n");
																			break;
																		}
																	default:
																		Console.WriteLine("try again \n");
																		run = true;
																		break;
																}
															}
															break;
														}
													case "8":
														{
															field[2, 1] = "_O_";
															print(field);
															field[1, 2] = "_X_";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									case "2":
										{
											field[0, 1] = "_O_|";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "3":
										{
											field[0, 2] = "_O_";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "4":
										{
											field[1, 0] = "_O_|";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "6":
										{
											field[1, 2] = "_O_";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "8":
										{
											field[0, 1] = " O |";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					case "8":
						{
							field[2, 1] = " O |";
							print(field);
							field[0, 2] = "_X_";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "1":
										{
											field[0, 0] = "_O_|";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "2":
										{
											field[0, 1] = "_O_|";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "4":
										{
											field[1, 0] = "_O_|";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "6":
										{
											field[1, 2] = "_O_";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "7":
										{
											field[2, 0] = " O |";
											print(field);
											field[0, 0] = "_X_|";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "2":
														{
															field[0, 1] = "_O_|";
															print(field);
															field[2, 2] = " X ";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "4":
														{
															field[1, 0] = "_O_|";
															print(field);
															field[2, 2] = " X ";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "6":
														{
															field[1, 2] = "_O_";
															print(field);
															field[0, 1] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "9":
														{
															field[2, 1] = " O ";
															print(field);
															field[0, 1] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									case "9":
										{
											field[2, 2] = " O ";
											print(field);
											field[2, 0] = " X |";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					case "9":
						{
							field[2, 2] = " O ";
							print(field);
							field[2, 0] = " X |";
							print(field);
							Console.WriteLine("write cell number \n");
							run = true;
							while (run)
							{
								run = false;
								number_cell = Console.ReadLine();
								switch (number_cell)
								{
									case "1":
										{
											field[0, 0] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "2":
										{
											field[0, 1] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "3":
										{
											field[0, 2] = "_O_";
											print(field);
											field[1, 2] = "_X_";
											print(field);
											Console.WriteLine("write cell number \n");
											run = true;
											while (run)
											{
												run = false;
												number_cell = Console.ReadLine();
												switch (number_cell)
												{
													case "1":
														{
															field[0, 0] = "_O_|";
															print(field);
															field[1, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "2":
														{
															field[0, 1] = "_O_|";
															print(field);
															field[1, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													case "4":
														{
															field[1, 0] = "_O_|";
															print(field);
															field[0, 1] = "_X_|";
															print(field);
															Console.WriteLine("write cell number \n");
															run = true;
															while (run)
															{
																run = false;
																number_cell = Console.ReadLine();
																switch (number_cell)
																{
																	case "1":
																		{
																			field[0, 0] = "_O_|";
																			print(field);
																			field[2, 1] = " X |";
																			print(field);
																			Console.WriteLine("you lose \n");
																			break;
																		}
																	case "8":
																		{
																			field[2, 1] = " O |";
																			print(field);
																			field[0, 0] = "_X_";
																			print(field);
																			Console.WriteLine("draw, congratulations! \n");
																			break;
																		}
																	default:
																		Console.WriteLine("try again \n");
																		run = true;
																		break;
																}
															}
															break;
														}
													case "8":
														{
															field[2, 1] = "_O_";
															print(field);
															field[1, 0] = "_X_|";
															print(field);
															Console.WriteLine("you lose \n");
															break;
														}
													default:
														Console.WriteLine("try again \n");
														run = true;
														break;
												}
											}
											break;
										}
									case "4":
										{
											field[1, 0] = "_O_|";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "6":
										{
											field[1, 2] = "_O_";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									case "8":
										{
											field[2, 1] = " O |";
											print(field);
											field[0, 2] = "_X_";
											print(field);
											Console.WriteLine("you lose \n");
											break;
										}
									default:
										Console.WriteLine("try again \n");
										run = true;
										break;
								}
							}
							break;
						}
					default:
						Console.WriteLine("try again \n");
						run = true;
						break;
				}
			}
		}
	}
}