from main import check
import pytest
@pytest.mark.parametrize(
    "s1,s2, expected",
    [
        ("roma","amor", True),
        ("emily", "emyli", True), 
        ("como", "hola", False), 
        ("calor", "lolo", True)
    ]
)

def test_ana(s1,s2, expected):
    assert check(s1,s2) == expected