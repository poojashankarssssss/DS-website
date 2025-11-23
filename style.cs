:root { --max:1000px; --accent:#2c6df6; font-family:Arial, sans-serif; }
*{box-sizing:border-box}
.container{max-width:var(--max);margin:0 auto;padding:16px}
.site-header{background:#f7f7f7;border-bottom:1px solid #e2e2e2}
.site-header .container{display:flex;align-items:center;justify-content:space-between}
.logo{font-weight:700;text-decoration:none;color:#111;font-size:20px}
.main-nav a{margin-left:16px;text-decoration:none;color:#333;font-weight:500}
#menu-toggle{display:none;font-size:26px;background:none;border:none}
@media(max-width:720px){ .main-nav{display:none} #menu-toggle{display:block} }
main{padding:28px 0}
.site-footer{border-top:1px solid #eaeaea;padding:12px 0;text-align:center;color:#666;margin-top:40px}
.faculty-card{border:1px solid #e6e6e6;padding:12px;border-radius:8px;margin-bottom:12px;display:flex;gap:12px;align-items:center}
.faculty-card img{width:80px;height:80px;object-fit:cover;border-radius:50%}
.table-syllabus{width:100%;border-collapse:collapse;margin-top:16px}
.table-syllabus th,.table-syllabus td{border:1px solid #ddd;padding:8px;text-align:left}
.quick-links ul{list-style:disc;padding-left:20px}
