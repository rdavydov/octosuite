import random
import getpass
from octosuite.colors import red, white, green, reset


# banners.py
# This file holds the program's banners and version tag
version_tag = "2.2.3"


def ascii_banner():
    ascii_banners = [
"""
  _______        __          _______         __ __         
 |       |.----.|  |_.-----.|     __|.--.--.|__|  |_.-----.
 |   -   ||  __||   _|  _  ||__     ||  |  ||  |   _|  -__|
 |_______||____||____|_____||_______||_____||__|____|_____|
                                                    """, 
"""
╔═╗┌─┐┌┬┐┌─┐╔═╗┬ ┬┬┌┬┐┌─┐
║ ║│   │ │ │╚═╗│ ││ │ ├┤ 
╚═╝└─┘ ┴ └─┘╚═╝└─┘┴ ┴ └─┘
                      """,
"""
░▒█▀▀▀█░█▀▄░▀█▀░▄▀▀▄░▒█▀▀▀█░█░▒█░░▀░░▀█▀░█▀▀
░▒█░░▒█░█░░░░█░░█░░█░░▀▀▀▄▄░█░▒█░░█▀░░█░░█▀▀
░▒█▄▄▄█░▀▀▀░░▀░░░▀▀░░▒█▄▄▄█░░▀▀▀░▀▀▀░░▀░░▀▀▀
                                         """,
"""
 ▄▀▄ ▄▀▀ ▀█▀ ▄▀▄ ▄▀▀ █ █ █ ▀█▀ ██▀
 ▀▄▀ ▀▄▄  █  ▀▄▀ ▄██ ▀▄█ █  █  █▄▄
                              """]
    ascii_banner = random.choice(ascii_banners)
    return f"""{ascii_banner} v{version_tag}
                          {white}— Advanced Github {red}OSINT{white} Framework
.:{getpass.getuser()}:.
├─ use ‘{green}help{reset}{white}’ command for usage
└╼ commands are case insensitive{reset}
"""
